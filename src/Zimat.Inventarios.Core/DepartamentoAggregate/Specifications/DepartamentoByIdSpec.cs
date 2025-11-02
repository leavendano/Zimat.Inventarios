using Ardalis.Specification;


namespace Zimat.Inventarios.Core.DepartamentoAggregate.Specifications;
public class DepartamentoByIdSpec : Specification<Departamento>
{
  public DepartamentoByIdSpec(Guid departamentoId)
  {
    Query
        .Where(departamento => departamento.Id == departamentoId);
  }
}
