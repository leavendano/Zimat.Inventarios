using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ProveedorAggregate;
public class Proveedor : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
  public Proveedor(string clave, string nombre, string rfc, string codigoPostal) : base()
  {
    Clave = Guard.Against.NullOrEmpty(clave, nameof(clave));
    Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
    Rfc = Guard.Against.NullOrEmpty(rfc, nameof(rfc));
    CodigoPostal = Guard.Against.NullOrEmpty(codigoPostal, nameof(codigoPostal));
    Id = UuidV7.NewGuid();
    Status = RegisterStatus.Activo; // Activo por defecto
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;
  }
  public string Clave {  get; private set; }
  public string Nombre {  get; private set; }

  public void UpdateClave(string newClave) => Clave = Guard.Against.NullOrEmpty(newClave, nameof(newClave));
  public void UpdateNombre(string newNombre) => Nombre = Guard.Against.NullOrEmpty(newNombre, nameof(newNombre));
  public void UpdateRfc(string newRfc) => Rfc = Guard.Against.NullOrEmpty(newRfc, nameof(newRfc));
  public void UpdateCodigoPostal(string newCodigoPostal) => CodigoPostal = Guard.Against.NullOrEmpty(newCodigoPostal, nameof(newCodigoPostal));

  public string? Calle {  get; set; }
  public string? NumeroExterior {  get; set; }
  public string? Colonia { get;set; }
  public string? Ciudad { get;set; }
  public string? Estado { get; set; }
  public string CodigoPostal { get; private set; } 
  public string? Telefono { get; set; }
  public string? Email { get; set; }
  public string? Clasificacion { get; set; }
  
  public string? Contacto { get; set; }
  public string Rfc { get; private set;} 
  public int DiasCredito { get; set; } = 0;
  public string? CuentaContable {  get; set; }
  public int TipoProveedor { get; set; } = 1; 
   public string? User { get; set;}	
  public int Status { get; set;}
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}


}
