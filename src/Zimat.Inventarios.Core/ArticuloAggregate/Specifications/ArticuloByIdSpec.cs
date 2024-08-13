using Ardalis.Specification;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.Base;


namespace Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;
public class ArticuloByIdSpec : Specification<Articulo>
{
  public ArticuloByIdSpec(Guid articuloId)
  {
    Query
        .Where(articulo => articulo.Id == articuloId);
  }

}
