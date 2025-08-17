using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.DepartamentoAggregate;

public class Departamento : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{

  public Departamento(string nombre,string user = "Administrador") : base()
  
    
    // Generar un nuevo ID si no se proporciona uno
  {
    Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
    User = Guard.Against.NullOrEmpty(user, nameof(user));
    Id = UuidV7.NewGuid();
    Status = RegisterStatus.Activo; // Activo por defecto
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;
  }
  
  public string Nombre { get; set; } 
  public string? User { get; set; } 
  public int Status { get; set; } 
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }

}
