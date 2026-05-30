using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Get;

public class GetKardexHandler(IReadRepository<Core.KardexAggregate.Kardex> _repository)
    : IQueryHandler<GetKardexQuery, Result<KardexDTO>>
{
    public async Task<Result<KardexDTO>> Handle(GetKardexQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(request.KardexId, cancellationToken);
        if (entity == null) return Result.NotFound();

        return new KardexDTO(
            entity.Id,
            entity.ArticuloId,
            entity.AlmacenId,
            entity.TipoMovimiento,
            entity.Fecha,
            entity.Cantidad,
            entity.CostoUnitario,
            entity.CostoTotal,
            entity.ReferenciaId,
            entity.User);
    }
}
