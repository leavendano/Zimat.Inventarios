using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.DocumentoAggregate;
using Zimat.Inventarios.Core.Extensions;  


namespace Zimat.Inventarios.UseCases.Documentos.Create;
public class CreateDocumentoHandler(IRepository<Documento> _repository)  : ICommandHandler<CreateDocumentoCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateDocumentoCommand request, CancellationToken cancellationToken)
  {

    var newItem = new Documento(request.Folio, request.Fecha, request.ClienteId, request.ProveedorId, request.Importe);

    
    foreach ( var item in request.conceptos.OrEmptyIfNull())
    {
      newItem.AddConcepto(new DocumentoConcepto(newItem.Id,item.ArticuloId,item.Precio,item.Precio,item.Cantidad,item.Impuesto1));  
    }  

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}
