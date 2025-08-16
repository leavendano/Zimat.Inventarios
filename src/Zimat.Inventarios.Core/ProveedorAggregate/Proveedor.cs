using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ProveedorAggregate;
public class Proveedor : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
  public Proveedor(string clave,string nombre, string rfc, string codigoPostal ) : base()
  {
    Clave = Guard.Against.NullOrEmpty(clave,nameof(clave));
    Nombre = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
    Rfc = Guard.Against.NullOrEmpty(rfc, nameof(rfc));
    CodigoPostal = Guard.Against.NullOrEmpty(codigoPostal, nameof(codigoPostal));
    Id = new UuidV7().Value;
  }
  public string Clave {  get; private set; } 
  public string Nombre {  get; private set; } 
  public string? Calle {  get; set; }
  public string? NumeroExterior {  get; set; }
  public string? Colonia { get;set; }
  public string? Ciudad { get;set; }
  public string? Estado { get; set; }
  public string CodigoPostal { get; private set; } 
  public string? Telefono { get; set; }
  public string? Email { get; set; }
  public string? Clasificacion { get; set; }
  public DateTime? UltimaCompra {  get; set; }
  public string? Contacto { get; set; }
  public string Rfc { get; private set;} 
  public int DiasCredito { get; set; } = 0;
  public string? CuentaContable {  get; set; }
  public int TipoProveedor { get; set; } = 1; 
   public string? Usuario { get; set;}	
  public bool Estado { get; set;} = true;
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}


}
