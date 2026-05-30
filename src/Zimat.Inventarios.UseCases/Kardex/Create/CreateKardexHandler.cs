using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.KardexAggregate;

namespace Zimat.Inventarios.UseCases.Kardex.Create;

public class CreateKardexHandler(IRepository<Core.KardexAggregate.Kardex> _repository)
    : ICommandHandler<CreateKardexCommand, Result<Guid>>
{
    public async Task<Result<Guid>> Handle(CreateKardexCommand request, CancellationToken cancellationToken)
    {
        var newKardex = new Core.KardexAggregate.Kardex(
            request.ArticuloId,
            request.AlmacenId,
            request.TipoMovimiento,
            request.Fecha,
            request.Cantidad,
            request.CostoUnitario);

        newKardex.ReferenciaId = request.ReferenciaId;
        newKardex.User = request.UserName;

        var createdItem = await _repository.AddAsync(newKardex, cancellationToken);

        return createdItem.Id;
    }
}
