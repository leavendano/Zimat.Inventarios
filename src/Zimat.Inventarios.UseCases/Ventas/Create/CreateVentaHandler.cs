using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.VentaAggregate;
using Zimat.Inventarios.Core.Extensions;


namespace Zimat.Inventarios.UseCases.Ventas.Create;
public class CreateVentaHandler(IRepository<Venta> _repository, IRepository<Articulo> _articulos) : ICommandHandler<CreateVentaCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateVentaCommand request, CancellationToken cancellationToken)
  {

    var newItem = new Venta(request.Folio, request.Fecha, request.ClienteId, request.Importe);


    foreach (var item in request.conceptos.OrEmptyIfNull())
    {
      newItem.AddConcepto(new VentaConcepto(newItem.Id, item.ArticuloId, item.Precio, item.Costo, item.Cantidad, item.Impuesto1));
    }

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    if (createdItem is not null)
    {
      foreach (var item in request.conceptos.OrEmptyIfNull())
      {
        var existingArticulo = await _articulos.GetByIdAsync(item.ArticuloId, cancellationToken);

        // Para ventas, siempre se resta del inventario (salida de mercancía)
        existingArticulo?.UpdateStock(-item.Cantidad);
        if (existingArticulo is not null)
          await _articulos.UpdateAsync(existingArticulo, cancellationToken);
      }

      return createdItem.Id;
    }

    return Guid.Empty;
  }
}
