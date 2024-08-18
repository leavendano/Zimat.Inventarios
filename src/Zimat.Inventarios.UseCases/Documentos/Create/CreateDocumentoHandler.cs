using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.DocumentoAggregate;


namespace Zimat.Inventarios.UseCases.Documentos.Create;
public class CreateDocumentoHandler(IRepository<Documento> _repository)  : ICommandHandler<CreateDocumentoCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateDocumentoCommand request, CancellationToken cancellationToken)
  {

    var newItem = new Documento(request.Folio, request.Fecha, request.ClienteId, request.ProveedorId, request.Importe);

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}
