using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.DocumentoAggregate;
using Zimat.Inventarios.Core.Extensions;  


namespace Zimat.Inventarios.UseCases.Documentos.Create;
public class CreateDocumentoHandler(IRepository<Documento> _repository,IRepository<Articulo> _articulos)  : ICommandHandler<CreateDocumentoCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateDocumentoCommand request, CancellationToken cancellationToken)
  {

    var newItem = new Documento(request.Folio, request.Fecha, request.ClienteId, request.ProveedorId, request.Importe);

    
    foreach ( var item in request.conceptos.OrEmptyIfNull())
    {
      newItem.AddConcepto(new DocumentoConcepto(newItem.Id,item.ArticuloId,item.Precio,item.Precio,item.Cantidad,item.Impuesto1));  
    }  

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    if (createdItem is not null)
    {
      foreach (var item in request.conceptos.OrEmptyIfNull())
      {
        var existingArticulo = await _articulos.GetByIdAsync(item.ArticuloId, cancellationToken);

       
        existingArticulo?.UpdateStock(request.TipoDocumentoId > 50? -item.Cantidad:item.Cantidad);
        if(existingArticulo is not null)
          await _articulos.UpdateAsync(existingArticulo, cancellationToken);
      }
      
      return createdItem.Id;
    }

    return Guid.Empty;
  }
}
