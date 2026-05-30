using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Clientes.List;

public class ListClientesHandler(IListClientesQueryService _query)
  : IQueryHandler<ListClientesQuery, Result<IEnumerable<ClienteDTO>>>
{
  public async Task<Result<IEnumerable<ClienteDTO>>> Handle(ListClientesQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync(request.filtro,request.Skip,request.Take);

    return Result.Success(result);
  }
}