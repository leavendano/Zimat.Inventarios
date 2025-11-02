using Ardalis.Specification;


namespace Zimat.Inventarios.Core.FamiliaAggregate.Specifications;
public class FamiliaByIdSpec : Specification<Familia>
{
  public FamiliaByIdSpec(Guid familiaId)
  {
    Query
        .Where(familia => familia.Id == familiaId);
  }
}
