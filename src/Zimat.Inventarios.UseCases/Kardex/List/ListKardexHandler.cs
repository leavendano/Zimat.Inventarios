using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.List;

public class ListKardexHandler(IListKardexQueryService _query)
    : IQueryHandler<ListKardexQuery, Result<IEnumerable<KardexListarDTO>>>
{
    public async Task<Result<IEnumerable<KardexListarDTO>>> Handle(ListKardexQuery request, CancellationToken cancellationToken)
    {
        var result = await _query.ListAsync(request.ArticuloId, request.AlmacenId, request.Skip, request.Take);

        return Result.Success(result);
    }
}
