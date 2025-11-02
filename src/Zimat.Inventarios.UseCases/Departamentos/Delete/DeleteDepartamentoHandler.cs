using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.DepartamentoAggregate;

namespace Zimat.Inventarios.UseCases.Departamentos.Delete;

public class DeleteDepartamentoHandler(IRepository<Departamento> _repository)
  : ICommandHandler<DeleteDepartamentoCommand, Result>
{
  public async Task<Result> Handle(DeleteDepartamentoCommand request, CancellationToken cancellationToken)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(request.DepartamentoId, cancellationToken);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete, cancellationToken);
    return Result.Success();
  }
}
