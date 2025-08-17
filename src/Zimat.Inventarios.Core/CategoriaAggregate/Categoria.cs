using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.CategoriaAggregate;

public class Categoria : EntityBase<Guid>,IAggregateRoot, IRegisterBase
{

  public Categoria(string descripcion, decimal margen = 0, string user = "Administrador") : base()
  {
    Descripcion = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
    Margen = Guard.Against.Negative(margen, nameof(margen));
    User = Guard.Against.NullOrEmpty(user, nameof(user));
    
    // Generar un nuevo ID si no se proporciona uno
    Status = RegisterStatus.Activo; // Activo por defecto
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;

    Id = UuidV7.NewGuid();
  }

  public string Descripcion { get; set; } 
  public decimal Margen { get; set; } 
  public string? User { get; set; } 
  public int Status { get; set; } 
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

}
