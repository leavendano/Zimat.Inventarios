using Ardalis.Specification;


namespace Zimat.Inventarios.Core.UnidadAggregate.Specifications;
public class UnidadByIdSpec : Specification<Unidad>
{
  public UnidadByIdSpec(int unidadId)
  {
    Query
        .Where(unidad => unidad.Id == unidadId);
  }
}
