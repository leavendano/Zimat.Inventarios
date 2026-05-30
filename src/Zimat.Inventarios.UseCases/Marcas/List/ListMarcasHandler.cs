using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Marcas.List;

public class ListMarcasHandler(IListMarcasQueryService _query)
    : IQueryHandler<ListMarcasQuery, Result<IEnumerable<MarcaDTO>>>
{
    public async Task<Result<IEnumerable<MarcaDTO>>> Handle(ListMarcasQuery request, CancellationToken cancellationToken)
    {
        var result = await _query.ListAsync(request.Skip, request.Take);
        return Result.Success(result);
    }
}
