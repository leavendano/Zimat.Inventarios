using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Ventas.List;

public class ListVentasHandler(IListVentasQueryService _query)
  : IQueryHandler<ListVentasQuery, Result<IEnumerable<VentaDTO>>>
{
  public async Task<Result<IEnumerable<VentaDTO>>> Handle(ListVentasQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync(request.ClienteId, request.TipoDocumentoId);

    return Result.Success(result);
  }
}
