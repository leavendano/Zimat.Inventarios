using Ardalis.Specification;

namespace Zimat.Inventarios.Core.ClienteAggregate.Specifications;

public class ClienteByIdSpec : Specification<Cliente>
{
  public ClienteByIdSpec(Guid clienteId)
  {
    Query
        .Where(cliente => cliente.Id == clienteId);
  }
}