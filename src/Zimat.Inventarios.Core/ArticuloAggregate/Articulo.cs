using System.Xml.Linq;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate.Events;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class Articulo : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
    

	public Articulo(string clave,string descripcion,decimal precioPublico, int unidadId, string? usuario) : base()
	{
		Clave = Guard.Against.NullOrEmpty(clave, nameof(clave));
		Descripcion = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
		PrecioPublico = Guard.Against.NegativeOrZero(precioPublico,nameof(precioPublico));
		Id = new UuidV7().Value;
		UnidadId = Guard.Against.NegativeOrZero(unidadId, nameof(unidadId));
		Usuario = usuario;
		Estatus = 1;
	}
  public string Clave {get; private set;}
	public string Descripcion { get; private set;} 
	public string? Codigo { get; set;}
	public int UnidadId  { get; set;} 
	public string? Marca  { get; set;}
	public string? Modelo  { get; set;}
	public int? LineaId  { get; set;} 
	public int? FamiliaId  { get; set;}
	public int? CategoriaId  { get; set;}
	public int? DepartamentoId  { get; set;}
	public string? Ubicacion  { get; set;}
	public bool Series  { get; set;}
	public decimal Impuesto1 { get; set;}
	public decimal Impuesto2  { get; set;}
	public DateTime? UltimaCompra { get; set;}
	public DateTime? UltimaVenta  { get; set;}
	public decimal Existencia { get; set;}=0;
	public decimal Minimo  { get; set;} = 0;
  public decimal Maximo { get; set; } = 0;
  public decimal Reorden { get; set; } = 0;
  public decimal PrecioPublico { get; private set;} 
  public decimal DescuentoMaximo { get; set;}
	public decimal? UltimoCosto { get; set;}
  public bool Activo { get; set; } = true;
  public string? Usuario { get; set;}	
  public int Estatus { get; set;}
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}


	public void UpdateDescripcion(string newName)
	{
		Descripcion = Guard.Against.NullOrEmpty(newName, nameof(newName));
		
	}

	public void UpdatePrecio(decimal nuevoPrecio)
	{
		PrecioPublico = Guard.Against.NegativeOrZero(nuevoPrecio,nameof(nuevoPrecio));
	}

}
