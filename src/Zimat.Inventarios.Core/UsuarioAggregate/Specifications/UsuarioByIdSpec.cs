using Ardalis.Specification;

namespace Zimat.Inventarios.Core.UsuarioAggregate.Specifications;

public class UsuarioByIdSpec : Specification<Usuario>
{
  public UsuarioByIdSpec(Guid usuarioId)
  {
    Query.Where(usuario => usuario.Id == usuarioId);
  }
}