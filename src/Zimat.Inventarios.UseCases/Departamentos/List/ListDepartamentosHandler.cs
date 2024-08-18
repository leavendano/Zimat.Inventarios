using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Departamentos.List;
public class ListDepartamentosHandler(IListDepartamentosQueryService _query) : IQueryHandler<ListDepartamentosQuery, Result<IEnumerable<DepartamentoDTO>>>
{
  public async Task<Result<IEnumerable<DepartamentoDTO>>> Handle(ListDepartamentosQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}

