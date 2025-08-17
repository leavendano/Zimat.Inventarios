using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.FamiliaAggregate;

public class Familia : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{

  public Familia(string descripcion, decimal margen = 0, string user = "Administrador") : base()
  {
    Descripcion  = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
    Margen  = Guard.Against.Negative(margen, nameof(margen));
    User  = Guard.Against.NullOrEmpty(user, nameof(user));
    Id = UuidV7.NewGuid();
    Status = RegisterStatus.Activo; // Activo por defecto
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;
  }
  public string Descripcion { get; set; } 
  public decimal Margen { get; set; } 
  public string? User { get; set; } 
  public int Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
