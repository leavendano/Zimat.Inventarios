namespace Zimat.Inventarios.UseCases.Articulos;

public record ArticuloListarDTO(Guid Id, string Clave, string Descripcion, decimal PrecioPublico, decimal? UltimoCosto,
  decimal Impuesto1, string Unidad, decimal StockActual, string? RutaImagen)
{
  public string ClaveDescripcion { get; } = Clave + " " + Descripcion;
  public decimal Cantidad { get; set; } = 1;
}
