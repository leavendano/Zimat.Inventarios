namespace Zimat.Inventarios.UseCases.Articulos;

public class ArticuloEditarDTO
{
  public Guid Id { get; set; }
  public string? Clave {get; private set;}
  public string? Descripcion { get; private set;} 
  public string? Observaciones { get; set;}
  public string? CodigoBarras { get; set; }
  public Guid UnidadId  { get; set;} 
  public string? Marca  { get; set;}
  public string? Modelo  { get; set;}
  public Guid? LineaId  { get; set;} 
  public Guid? FamiliaId  { get; set;}
  public Guid? CategoriaId  { get; set;}
  public Guid? DepartamentoId  { get; set;}
  public string? Ubicacion  { get; set;}
  public bool Series  { get; set;}
  public decimal Impuesto1 { get; set;}
  public decimal Impuesto2  { get; set;}
  public string? ClaveSat { get; set;}
  public Guid? UltimaCompra { get; set; }
  public Guid? UltimaVenta  { get; set;}
  public decimal StockActual { get; set;}
  public decimal StockMinimo  { get; set;} 
  public decimal StockMaximo { get; set; } 
  public int StockStatus { get; set; } = 0; // 0: Normal, 1: Bajo, 2: Alto
  
  public decimal PrecioPublico { get; set; } 
  public decimal DescuentoMaximo { get; set;}
  public decimal? CostoUnitario { get; set;}
  public decimal? CostoPromedio { get; set;}
  public string? RutaImagen { get; set; }
}