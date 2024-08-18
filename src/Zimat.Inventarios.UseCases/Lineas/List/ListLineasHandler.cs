using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Lineas.List;
public class ListLineasHandler(IListLineasQueryService _query) : IQueryHandler<ListLineasQuery, Result<IEnumerable<LineaDTO>>>
{
  public async Task<Result<IEnumerable<LineaDTO>>> Handle(ListLineasQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
