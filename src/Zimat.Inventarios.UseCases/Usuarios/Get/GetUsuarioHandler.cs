using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UsuarioAggregate;
using Zimat.Inventarios.Core.UsuarioAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Usuarios.Get;

public class GetUsuarioHandler(IReadRepository<Usuario> _repository)
  : IQueryHandler<GetUsuarioQuery, Result<UsuarioDTO>>
{
  public async Task<Result<UsuarioDTO>> Handle(GetUsuarioQuery request, CancellationToken cancellationToken)
  {
    var spec = new UsuarioByIdSpec(request.UsuarioId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return Result.Success(new UsuarioDTO(entity.Id, entity.Clave, entity.Nombre, entity.Email, entity.Nivel, entity.EsVendedor, entity.Comision, entity.ListaPrecio));
  }
}