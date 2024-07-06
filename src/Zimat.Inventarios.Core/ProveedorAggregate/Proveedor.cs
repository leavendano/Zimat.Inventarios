using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ProveedorAggregate;
public class Proveedor(string clave,string nombre, string rfc, string codigoPostal ) : RegisterBase, IAggregateRoot
{
  public string Clave {  get; private set; } = Guard.Against.NullOrEmpty(clave,nameof(clave));
  public string Nombre {  get; private set; } = Guard.Against.NullOrEmpty(nombre, nameof(nombre));
  public string? Calle {  get; set; }
  public string? NumeroExterior {  get; set; }
  public string? Colonia { get;set; }
  public string? Ciudad { get;set; }
  public string? Estado { get; set; }
  public string CodigoPostal { get; private set; } = Guard.Against.NullOrEmpty(codigoPostal, nameof(codigoPostal));
  public string? Telefono { get; set; }
  public string? Email { get; set; }
  public string? Clasificacion { get; set; }
  public DateTime? UltimaCompra {  get; set; }
  public string? Contacto { get; set; }
  public string Rfc { get; private set;} = Guard.Against.NullOrEmpty(rfc, nameof(rfc));
  public int DiasCredito { get; set; } = 0;
  public string? CuentaContable {  get; set; }
  public int TipoProveedor { get; set; } = 1; 

}
