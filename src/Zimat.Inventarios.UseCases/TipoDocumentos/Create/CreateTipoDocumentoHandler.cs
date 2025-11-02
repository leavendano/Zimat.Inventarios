using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.TipoDocumentoAggregate;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Create;

public class CreateTipoDocumentoHandler(IRepository<TipoDocumento> _repository)
  : ICommandHandler<CreateTipoDocumentoCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateTipoDocumentoCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new TipoDocumento(
        request.Nombre,
        request.EsEntrada,
        request.EsSalida,
        request.AfectaInventario,
        request.AfectaCuentasPorPagar,
        request.AfectaCuentasPorCobrar,
        request.RequiereProveedor,
        request.RequiereCliente,
        request.UltimoFolio,
        request.Prefijo
    );

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}
