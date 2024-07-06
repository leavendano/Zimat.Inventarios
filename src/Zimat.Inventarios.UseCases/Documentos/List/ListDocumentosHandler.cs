using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.UseCases.Articulos.List;
using Zimat.Inventarios.UseCases.Articulos;

namespace Zimat.Inventarios.UseCases.Documentos.List;

  public class ListDocumentosHandler(IListDocumentosQueryService _query)
  : IQueryHandler<ListDocumentosQuery, Result<IEnumerable<DocumentoDTO>>>
{
  public async Task<Result<IEnumerable<DocumentoDTO>>> Handle(ListDocumentosQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}

