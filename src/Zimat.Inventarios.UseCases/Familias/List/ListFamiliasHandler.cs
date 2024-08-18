using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Familias.List;
public class ListFamiliasHandler(IListFamiliasQueryService _query) : IQueryHandler<ListFamiliasQuery, Result<IEnumerable<FamiliaDTO>>>
{
  public async Task<Result<IEnumerable<FamiliaDTO>>> Handle(ListFamiliasQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
