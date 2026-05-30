using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.UsuarioAggregate;

public class Usuario : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
  public Usuario(string clave, string nombre, string email, string nivel,bool esVendedor) : base()
  {
    Clave = Guard.Against.NullOrEmpty(clave, nameof(clave));
    Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
    Email = Guard.Against.NullOrEmpty(email, nameof(email));
    Nivel = Guard.Against.NullOrEmpty(nivel, nameof(nivel));
    Id = UuidV7.NewGuid();
    Status = RegisterStatus.Activo; // Activo por defecto
    EsVendedor = esVendedor;
    Comision = 0;
    ListaPrecio = 1;
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;
  }
  public string Clave { get; private set; }
  public string Nombre { get; private set; }
  public string Email { get; set; }
  public string Nivel { get; set; }
  public bool EsVendedor { get; set; }
  public decimal Comision { get; set; }
  public int ListaPrecio { get; set; }
  public string? User { get; set; }
  public int Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}