using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ContributorAggregate;

public class Articulo(string clave,string descripcion) : RegisterBase, IAggregateRoot
{
    
    public string Clave {get; set;} = Guard.Against.NullOrEmpty(clave, nameof(clave));
	public string Descripcion { get; set;} = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
	public string? Codigo { get; set;}
	public int UnidadId  { get; set;}
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
	public decimal Minimo  { get; set;}
	public decimal Maximo  { get; set;}
	public decimal Reorden  { get; set;}
	public string? Divisa { get; set;}
	public decimal UltimoCosto { get; set;}
	public bool Activo {  get; set;}

}
