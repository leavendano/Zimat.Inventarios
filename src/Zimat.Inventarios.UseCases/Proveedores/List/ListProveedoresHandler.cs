using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Proveedores.List;
public class ListProveedoresHandler(IListProveedoresQueryService _query)
  : IQueryHandler<ListProveedoresQuery, Result<IEnumerable<ProveedorDTO>>>
{
  public async Task<Result<IEnumerable<ProveedorDTO>>> Handle(ListProveedoresQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}

