using Ardalis.Specification;
using Zimat.Inventarios.Core.ArticuloAggregate;

namespace Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

public class ArticuloByIdWithUnidadesAndPreciosSpec : Specification<Articulo>
{
  public ArticuloByIdWithUnidadesAndPreciosSpec(Guid articuloId)
  {
    Query
        .Where(articulo => articulo.Id == articuloId)
        .Include(articulo => articulo.ArticuloUnidades)
            .ThenInclude(au => au.Unidad)
        .Include(articulo => articulo.ArticuloUnidades)
            .ThenInclude(au => au.Precios);
  }
}
