using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.TipoDocumentoAggregate;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Delete;

public class DeleteTipoDocumentoHandler(IRepository<TipoDocumento> _repository)
  : ICommandHandler<DeleteTipoDocumentoCommand, Result>
{
  public async Task<Result> Handle(DeleteTipoDocumentoCommand request, CancellationToken cancellationToken)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(request.TipoDocumentoId, cancellationToken);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete, cancellationToken);
    return Result.Success();
  }
}
