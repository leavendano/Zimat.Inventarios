using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Usuarios.List;

public class ListUsuariosHandler(IListUsuariosQueryService _query)
  : IQueryHandler<ListUsuariosQuery, Result<IEnumerable<UsuarioDTO>>>
{
  public async Task<Result<IEnumerable<UsuarioDTO>>> Handle(ListUsuariosQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync(request.filtro, request.Skip, request.Take);

    return Result.Success(result);
  }
}