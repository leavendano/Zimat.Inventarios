using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UsuarioAggregate;
using Zimat.Inventarios.Core.UsuarioAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Usuarios.Update;

public class UpdateUsuarioHandler(IRepository<Usuario> _repository)
  : ICommandHandler<UpdateUsuarioCommand, Result>
{
  public async Task<Result> Handle(UpdateUsuarioCommand request,
    CancellationToken cancellationToken)
  {
    var spec = new UsuarioByIdSpec(request.Id);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    entity.Email = request.Email;
    entity.Nivel = request.Nivel;
    entity.EsVendedor = request.EsVendedor;
    entity.Comision = request.Comision;
    entity.ListaPrecio = request.ListaPrecio;
    entity.UpdatedAt = DateTime.UtcNow;

    await _repository.UpdateAsync(entity, cancellationToken);

    return Result.Success();
  }
}