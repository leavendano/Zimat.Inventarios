using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.CompraAggregate;
using Zimat.Inventarios.Core.Extensions;


namespace Zimat.Inventarios.UseCases.Compras.Create;
public class CreateCompraHandler(IRepository<Compra> _repository) : ICommandHandler<CreateCompraCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateCompraCommand request, CancellationToken cancellationToken)
  {

    var newItem = new Compra(request.Folio, request.Fecha, request.ProveedorId, request.Importe,request.TipoDocumentoId);


    foreach (var item in request.conceptos.OrEmptyIfNull())
    {
      newItem.AddConcepto(new CompraConcepto(newItem.Id, item.ArticuloId, item.Precio, item.Precio, item.Cantidad, item.Impuesto1));
    }

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
    
  }
}
