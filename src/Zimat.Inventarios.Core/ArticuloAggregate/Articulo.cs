using System.Xml.Linq;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Articulo(string clave,string descripcion,decimal precioPublico) : RegisterBase, IAggregateRoot
{
    
  public string Clave {get; private set;} = Guard.Against.NullOrEmpty(clave, nameof(clave));
	public string Descripcion { get; private set;} = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
	public string? Codigo { get; set;}
	public string? Unidad  { get; set;}
	public string? Marca  { get; set;}
	public string? Modelo  { get; set;}
	public int? LineaId  { get; set;} 
	public int? FamiliaId  { get; set;}
	public string? CategoriaId  { get; set;}
	public int? DepartamentoId  { get; set;}
	public string? Ubicacion  { get; set;}
	public bool Series  { get; set;}
	public decimal Impuesto1 { get; set;}
	public decimal Impuesto2  { get; set;}
	public int? ProveedorId { get; set;}
	public DateTime? UltimaCompra { get; set;}
	public DateTime? UltimaVenta  { get; set;}
	public decimal Existencia { get; set;}=0;
	public decimal Minimo  { get; set;} = 0;
  public decimal Maximo { get; set; } = 0;
  public decimal Reorden { get; set; } = 0;
	public string? Divisa { get; set;}
  public decimal PrecioPublico { get; private set;} = Guard.Against.NegativeOrZero(precioPublico,nameof(precioPublico));
  public decimal DescuentoMaximo { get; set;}
	public decimal? UltimoCosto { get; set;}
  public bool Activo { get; set; } = true;

  public void UpdateDescripcion(string newName)
  {
    Descripcion = Guard.Against.NullOrEmpty(newName, nameof(newName));
  }

  public void UpdatePrecio(decimal nuevoPrecio)
  {
    PrecioPublico = Guard.Against.NegativeOrZero(nuevoPrecio,nameof(nuevoPrecio));
  }

}
