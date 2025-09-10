namespace Zimat.Inventarios.UseCases.Articulos;

public class ArticuloListarDTO
{
  public Guid Id { get; set; }
  public string Clave { get; set; } = string.Empty;
  public string Descripcion { get; set; } = string.Empty;
  public decimal PrecioPublico { get; set; }
  public decimal? UltimoCosto { get; set; }
  public decimal Impuesto1 { get; set; }
  public Guid UnidadId { get; set; }
  public string Unidad { get; set; } = string.Empty;
  public decimal StockActual { get; set; } = 0;
  public string? RutaImagen { get; set; }
  public decimal Cantidad { get; set; } = 1;
  public string ClaveDescripcion => Clave + " " + Descripcion;
}
