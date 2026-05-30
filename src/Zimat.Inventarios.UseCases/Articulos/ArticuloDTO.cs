using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos;
public record ArticuloDTO(Guid Id,string Clave,string Descripcion,decimal PrecioPublico,decimal? UltimoCosto,decimal Impuesto1, string? RutaImagen)
{
  public string ClaveDescripcion { get; } = Clave + " " + Descripcion;
}
