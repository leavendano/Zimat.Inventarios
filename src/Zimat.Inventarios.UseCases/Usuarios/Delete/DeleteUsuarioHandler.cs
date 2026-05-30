using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UsuarioAggregate;
using Zimat.Inventarios.Core.UsuarioAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Usuarios.Delete;

public class DeleteUsuarioHandler(IRepository<Usuario> _repository)
  : ICommandHandler<DeleteUsuarioCommand, Result>
{
  public async Task<Result> Handle(DeleteUsuarioCommand request,
    CancellationToken cancellationToken)
  {
    var aggregateToDelete = await _repository.FirstOrDefaultAsync(new UsuarioByIdSpec(request.UsuarioId), cancellationToken);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete, cancellationToken);
    return Result.Success();
  }
}