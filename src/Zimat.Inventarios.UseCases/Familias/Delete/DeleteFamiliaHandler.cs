using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.FamiliaAggregate;

namespace Zimat.Inventarios.UseCases.Familias.Delete;

public class DeleteFamiliaHandler(IRepository<Familia> _repository)
  : ICommandHandler<DeleteFamiliaCommand, Result>
{
  public async Task<Result> Handle(DeleteFamiliaCommand request, CancellationToken cancellationToken)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(request.FamiliaId, cancellationToken);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete, cancellationToken);
    return Result.Success();
  }
}
