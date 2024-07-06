using Ardalis.Specification;
using Zimat.Inventarios.Core.ArticuloAggregate;


namespace Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;
public class ArticuloByIdSpec : Specification<Articulo>
{
  public ArticuloByIdSpec(int articuloId)
  {
    Query
        .Where(articulo => articulo.Id == articuloId);
  }

}
