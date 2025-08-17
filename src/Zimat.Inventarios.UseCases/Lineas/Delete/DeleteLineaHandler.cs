using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.LineaAggregate;

namespace Zimat.Inventarios.UseCases.Lineas.Delete;

public class DeleteLineaHandler(IRepository<Linea> _repository)
  : ICommandHandler<DeleteLineaCommand, Result>
{
  public async Task<Result> Handle(DeleteLineaCommand request, CancellationToken cancellationToken)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(request.LineaId, cancellationToken);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete, cancellationToken);
    return Result.Success();
  }
}