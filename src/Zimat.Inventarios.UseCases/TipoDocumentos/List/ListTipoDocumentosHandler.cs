using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.List;

public class ListTipoDocumentosHandler(IListTipoDocumentosQueryService _query)
  : IQueryHandler<ListTipoDocumentosQuery, Result<IEnumerable<TipoDocumentoDTO>>>
{
  public async Task<Result<IEnumerable<TipoDocumentoDTO>>> Handle(ListTipoDocumentosQuery request,
    CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
