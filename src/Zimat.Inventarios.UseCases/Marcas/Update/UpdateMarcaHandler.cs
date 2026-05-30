using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.MarcaAggregate;

namespace Zimat.Inventarios.UseCases.Marcas.Update;

public class UpdateMarcaHandler(IRepository<Marca> _repository)
    : ICommandHandler<UpdateMarcaCommand, Result<MarcaDTO>>
{
    public async Task<Result<MarcaDTO>> Handle(UpdateMarcaCommand request, CancellationToken cancellationToken)
    {
        var existingItem = await _repository.GetByIdAsync(request.MarcaId, cancellationToken);
        if (existingItem == null) return Result.NotFound();

        existingItem.UpdateDescripcion(request.Descripcion);
        await _repository.UpdateAsync(existingItem, cancellationToken);

        return Result.Success(new MarcaDTO(existingItem.Id, existingItem.Descripcion));
    }
}
