using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.ContributorAggregate;

public class Articulo(string clave,string descripcion) : RegisterBase, IAggregateRoot
{
    
  public string Clave {get; set;} = Guard.Against.NullOrEmpty(clave, nameof(clave));
	public string Descripcion { get; set;} = Guard.Against.NullOrEmpty(descripcion, nameof(descripcion));
	public string? Codigo { get; set;}
	public string? Unidad  { get; set;}
	public string? Unidefa  { get; set;}
	public string? Marca  { get; set;}
	public string? Modelo  { get; set;}
	public string? Linea  { get; set;} 
	public string? Familia  { get; set;}
	public string? Categoria  { get; set;}
	public string? Numdep  { get; set;}
	public string? Valdep  { get; set;}
	public string? Ubicacion  { get; set;}
	public bool Series  { get; set;}
	public decimal Impuesto1 { get; set;}
	public decimal Impuesto2  { get; set;}
	public string? Numprov { get; set;}
	public string? Numprov1 { get; set;}
	public string? Numprov2 { get; set;}
	public string? Numprov3 { get; set;}
	public DateTime Ultcomp { get; set;}
	public DateTime Ultcomp1  { get; set;}
	public DateTime Ultcomp2  { get; set;}
	public DateTime Ultcomp3  { get; set;}
	public DateTime Ultvent  { get; set;}
	public decimal Existencia { get; set;}
	public decimal Minimo  { get; set;}
	public decimal Maximo  { get; set;}
	public decimal Reorden  { get; set;}
	public string? Divisa { get; set;}
	public decimal Precio1 { get; set;}
	public decimal Precio2 { get; set;}
	public decimal Precio3 { get; set;}
	public decimal Precio4 { get; set;}
	public decimal Precio5 { get; set;}
  public decimal Factor1 { get; set;}
  public decimal Factor2 { get; set;}
  public decimal Factor3 { get; set;}
  public decimal Factor4 { get; set;}
  public decimal Factor5 { get; set;}
  public decimal UltimoCosto { get; set;}
  public bool Activo {  get; set;}

}
