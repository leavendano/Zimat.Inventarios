namespace Zimat.Inventarios.UseCases.Articulos;

public record ArticuloListarDTO(Guid Id, string Clave, string Descripcion, decimal PrecioPublico, decimal? UltimoCosto, 
  decimal Impuesto1, string Unidad, string? RutaImagen)
{
  public string ClaveDescripcion { get; } = Clave + " " + Descripcion;
}
