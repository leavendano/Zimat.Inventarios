using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.List;
public class ListArticulosHandler(IListArticulosQueryService _query)
  : IQueryHandler<ListArticulosQuery, Result<IEnumerable<ArticuloListarDTO>>>
{
  public async Task<Result<IEnumerable<ArticuloListarDTO>>> Handle(ListArticulosQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync(request.filtro,request.Skip,request.Take);

    return Result.Success(result);
  }
}
