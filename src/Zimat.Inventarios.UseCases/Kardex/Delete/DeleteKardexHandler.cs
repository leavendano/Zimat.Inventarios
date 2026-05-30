using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Delete;

public class DeleteKardexHandler(IRepository<Core.KardexAggregate.Kardex> _repository)
    : ICommandHandler<DeleteKardexCommand, Result>
{
    public async Task<Result> Handle(DeleteKardexCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repository.GetByIdAsync(request.KardexId, cancellationToken);
        if (existing == null) return Result.NotFound();

        await _repository.DeleteAsync(existing, cancellationToken);
        return Result.Success();
    }
}
