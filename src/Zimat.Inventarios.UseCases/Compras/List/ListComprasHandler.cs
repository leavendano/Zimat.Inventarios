using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Compras.List;

public class ListComprasHandler(IListComprasQueryService _query)
  : IQueryHandler<ListComprasQuery, Result<IEnumerable<CompraListarDTO>>>
{
  public async Task<Result<IEnumerable<CompraListarDTO>>> Handle(ListComprasQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListComprasAsync(request.ProveedorId, request.TipoDocumentoId);

    return Result.Success(result);
  }
}
