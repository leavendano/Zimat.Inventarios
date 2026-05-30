using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.TipoDocumentoAggregate;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Update;

public class UpdateTipoDocumentoHandler(IRepository<TipoDocumento> _repository) :
    ICommandHandler<UpdateTipoDocumentoCommand, Result<TipoDocumentoDTO>>
{
  public async Task<Result<TipoDocumentoDTO>> Handle(UpdateTipoDocumentoCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.TipoDocumentoId, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }

    existingItem.Update(
        request.Nombre,
        request.EsEntrada,
        request.EsSalida,
        request.AfectaInventario,
        request.AfectaCuentasPorPagar,
        request.AfectaCuentasPorCobrar,
        request.RequiereProveedor,
        request.RequiereCliente,
        request.Prefijo
    );

    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success(new TipoDocumentoDTO(
        existingItem.Id,
        existingItem.Nombre,
        existingItem.EsEntrada,
        existingItem.EsSalida,
        existingItem.AfectaInventario,
        existingItem.AfectaCuentasPorPagar,
        existingItem.AfectaCuentasPorCobrar,
        existingItem.RequiereProveedor,
        existingItem.RequiereCliente,
        existingItem.Prefijo,
        existingItem.UltimoFolio
    ));
  }
}
