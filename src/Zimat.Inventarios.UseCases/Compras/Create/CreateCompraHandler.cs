using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.CompraAggregate;
using Zimat.Inventarios.Core.Extensions;


namespace Zimat.Inventarios.UseCases.Compras.Create;
public class CreateCompraHandler(IRepository<Compra> _repository, IRepository<Articulo> _articulos) : ICommandHandler<CreateCompraCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateCompraCommand request, CancellationToken cancellationToken)
  {

    var newItem = new Compra(request.Folio, request.Fecha, request.ProveedorId, request.Importe);


    foreach (var item in request.conceptos.OrEmptyIfNull())
    {
      newItem.AddConcepto(new CompraConcepto(newItem.Id, item.ArticuloId, item.Precio, item.Precio, item.Cantidad, item.Impuesto1));
    }

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    if (createdItem is not null)
    {
      foreach (var item in request.conceptos.OrEmptyIfNull())
      {
        var existingArticulo = await _articulos.GetByIdAsync(item.ArticuloId, cancellationToken);


        existingArticulo?.UpdateStock(request.TipoDocumentoId > 50 ? -item.Cantidad : item.Cantidad);
        if (existingArticulo is not null)
          await _articulos.UpdateAsync(existingArticulo, cancellationToken);
      }

      return createdItem.Id;
    }

    return Guid.Empty;
  }
}
