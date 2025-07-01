using Zimat.Inventarios.Core.ProveedorAggregate;

namespace Zimat.Inventarios.UseCases.Proveedores;

  public class ProveedorCrearDTO
  {
    public string Clave {  get; set; } = ""; 
    public string Nombre {  get; set; } = ""; 
    public string? Calle {  get; set; }
    public string NumeroExterior {  get; set; } = "";
    public string Colonia { get;set; } = "";
    public string Ciudad { get;set; } = "";
    public string Estado { get; set; } = "";
    public string CodigoPostal { get; set; } = ""; 
    public string Telefono { get; set; } = "";
    public string Email { get; set; } = "";
    public string Clasificacion { get; set; } = "";
    public DateTime? UltimaCompra {  get; set; }
    public string Contacto { get; set; } = "";
    public string Rfc { get; set;} = ""; 
    public int DiasCredito { get; set; } = 0;
    public string CuentaContable {  get; set; } = "";
    public int TipoProveedor { get; set; } = 1; 

    public Proveedor ToProveedor()
    {
      Proveedor item = new Proveedor(Clave,Nombre,Rfc,CodigoPostal);
      item.Email = Email;
      item.Estatus = 1;
      item.Calle = Calle;
      item.Ciudad = Ciudad;
      item.Estado = Estado;
      item.CuentaContable = CuentaContable;
      item.TipoProveedor = TipoProveedor;
      item.Colonia = Colonia;

      return item;
    }

  }