using System.Reflection;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.ProveedorAggregate;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.DocumentoAggregate;

namespace Zimat.Inventarios.Infrastructure.Data;
public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher? dispatcher)
      : base(options)
  {
    _dispatcher = dispatcher;
  }

  public DbSet<Contributor> Contributors => Set<Contributor>();
  public DbSet<Articulo> Articulos => Set<Articulo>();
  public DbSet<Categoria> Categorias => Set<Categoria>();
  public DbSet<Departamento> Departamentos => Set<Departamento>();
  public DbSet<Familia> familias => Set<Familia>();
  public DbSet<Linea> Linea => Set<Linea>();
  public DbSet<Unidad> Unidades => Set<Unidad>();
  public DbSet<Proveedor> Proveedores => Set<Proveedor>();
  public DbSet<Documento> Documentos => Set<Documento>();
  public DbSet<DocumentoConcepto> DocumentoConceptos => Set<DocumentoConcepto>();


  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
          => optionsBuilder.UseSnakeCaseNamingConvention();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {

    var entries = ChangeTracker.Entries<RegisterBase>().
                 Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            foreach (var entityEntry in entries)
            {
                entityEntry.Entity.UpdatedAt = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Entity.CreatedAt = DateTime.UtcNow;
                }
            }


    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null) return result;

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges() =>
        SaveChangesAsync().GetAwaiter().GetResult();
}
