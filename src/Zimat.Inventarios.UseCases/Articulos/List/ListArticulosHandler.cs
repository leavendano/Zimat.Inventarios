using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.List;
public class ListArticulosHandler(IListArticulosQueryService _query)
  : IQueryHandler<ListArticulosQuery, Result<IEnumerable<ArticuloDTO>>>
{
  public async Task<Result<IEnumerable<ArticuloDTO>>> Handle(ListArticulosQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
