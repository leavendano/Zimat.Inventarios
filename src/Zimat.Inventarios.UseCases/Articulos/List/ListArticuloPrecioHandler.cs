

using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Articulos.List;


class ListArticuloPrecioHandler(IListArticulosQueryService _query)
  : IQueryHandler<ListArticuloPrecioQuery, Result<IEnumerable<ArticuloPrecioListarDTO>>>
{
  public async Task<Result<IEnumerable<ArticuloPrecioListarDTO>>> Handle(ListArticuloPrecioQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListPreciosAsync(request.filtro,request.Skip,request.Take);

    return Result.Success(result);
  }
}