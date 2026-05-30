using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.MarcaAggregate;
using Zimat.Inventarios.Core.MarcaAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Marcas.Delete;

public class DeleteMarcaHandler(IRepository<Marca> _repository)
    : ICommandHandler<DeleteMarcaCommand, Result>
{
    public async Task<Result> Handle(DeleteMarcaCommand request, CancellationToken cancellationToken)
    {
        var spec = new MarcaByIdSpec(request.MarcaId);
        var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
        if (entity == null) return Result.NotFound();

        await _repository.DeleteAsync(entity, cancellationToken);
        return Result.Success();
    }
}
