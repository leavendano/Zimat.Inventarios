using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Unidades.List;
public class ListUnidadesHandler(IListUnidadesQueryService _query)  : IQueryHandler<ListUnidadesQuery, Result<IEnumerable<UnidadDTO>>>
{
  public async Task<Result<IEnumerable<UnidadDTO>>> Handle(ListUnidadesQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync(request.articuloId, request.Skip, request.Take);

    return Result.Success(result);
  }
}
