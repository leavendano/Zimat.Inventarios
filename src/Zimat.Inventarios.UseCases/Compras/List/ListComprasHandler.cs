using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Compras.List;

public class ListComprasHandler(IListComprasQueryService _query)
  : IQueryHandler<ListComprasQuery, Result<IEnumerable<CompraDTO>>>
{
  public async Task<Result<IEnumerable<CompraDTO>>> Handle(ListComprasQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync(request.ProveedorId, request.TipoDocumentoId);

    return Result.Success(result);
  }
}
