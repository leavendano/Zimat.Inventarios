using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Interfaces;
using Zimat.Inventarios.Core.Services;
using Zimat.Inventarios.Infrastructure.Data;
using Zimat.Inventarios.Infrastructure.Data.Queries;
using Zimat.Inventarios.Infrastructure.Email;
using Zimat.Inventarios.UseCases.Contributors.List;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Zimat.Inventarios.UseCases.Articulos.List;
using Zimat.Inventarios.UseCases.Documentos.List;
using Zimat.Inventarios.UseCases.Proveedores.List;
using Zimat.Inventarios.UseCases.Unidades.List;

namespace Zimat.Inventarios.Infrastructure;
public static class InfrastructureServiceExtensions
{
  public static IServiceCollection AddInfrastructureServices(
    this IServiceCollection services,
    ConfigurationManager config,
    ILogger logger)
  {
    string? connectionString = config.GetConnectionString("DefaultConnection");
    Guard.Against.Null(connectionString);
    services.AddDbContext<AppDbContext>(options =>
     options.UseNpgsql(connectionString));

    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
    services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
    services.AddScoped<IListContributorsQueryService, ListContributorsQueryService>();
    services.AddScoped<IDeleteContributorService, DeleteContributorService>();
    services.AddScoped<IListArticulosQueryService, ListArticulosQueryService>();
    services.AddScoped<IDeleteArticuloService, DeleteArticuloService>();
    services.AddScoped<IListDocumentosQueryService, ListDocumentosQueryService>();
    services.AddScoped<IListProveedoresQueryService, ListProveedoresQueryService>();
    services.AddScoped<IListUnidadesQueryService, ListUnidadesQueryService>();
    services.Configure<MailserverConfiguration>(config.GetSection("Mailserver"));

    logger.LogInformation("{Project} services registered", "Infrastructure");

    return services;
  }
}
