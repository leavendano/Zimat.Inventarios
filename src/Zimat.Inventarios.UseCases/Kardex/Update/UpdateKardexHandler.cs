using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Update;

public class UpdateKardexHandler(IRepository<Core.KardexAggregate.Kardex> _repository)
    : ICommandHandler<UpdateKardexCommand, Result<KardexDTO>>
{
    public async Task<Result<KardexDTO>> Handle(UpdateKardexCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repository.GetByIdAsync(request.KardexId, cancellationToken);
        if (existing == null) return Result.NotFound();

        existing.UpdateCantidad(request.Cantidad);
        existing.UpdateCosto(request.CostoUnitario);

        await _repository.UpdateAsync(existing, cancellationToken);

        return new KardexDTO(
            existing.Id,
            existing.ArticuloId,
            existing.AlmacenId,
            existing.TipoMovimiento,
            existing.Fecha,
            existing.Cantidad,
            existing.CostoUnitario,
            existing.CostoTotal,
            existing.ReferenciaId,
            existing.User);
    }
}
