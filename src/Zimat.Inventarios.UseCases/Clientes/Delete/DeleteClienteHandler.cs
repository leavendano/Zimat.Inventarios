using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ClienteAggregate;

namespace Zimat.Inventarios.UseCases.Clientes.Delete;

public class DeleteClienteHandler(IRepository<Cliente> _repository) :
    ICommandHandler<DeleteClienteCommand, Result>
{
  public async Task<Result> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(request.ClienteId, cancellationToken);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete, cancellationToken);

    return Result.Success();
  }
}