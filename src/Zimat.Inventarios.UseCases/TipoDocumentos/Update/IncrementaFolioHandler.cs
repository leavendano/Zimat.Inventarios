using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.TipoDocumentoAggregate;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Update;
public class IncrementaFolioHandler(IRepository<TipoDocumento> _repository) :
    ICommandHandler<IncrementaFolioCommand, Result<TipoDocumentoDTO>>
{
  public async Task<Result<TipoDocumentoDTO>> Handle(IncrementaFolioCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.TipoDocumentoId, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }
    existingItem.UpdateUltimoFolio(existingItem.UltimoFolio + 1);
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
