using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos;
public record ArticuloDTO(Guid Id,string Clave,string Descripcion,decimal PrecioPublico);
