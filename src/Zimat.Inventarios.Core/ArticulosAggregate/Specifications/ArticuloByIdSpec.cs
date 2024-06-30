using Ardalis.Specification;
using Zimat.Inventarios.Core.ContributorAggregate;

namespace Zimat.Inventarios.Core.ArticulosAgrregate.Specifications;
public class ArticuloByIdSpec : Specification<Articulo>
{
  public ArticuloByIdSpec(int articuloId)
  {
    Query
        .Where(articulo => articulo.Id == articuloId);
  }

}
