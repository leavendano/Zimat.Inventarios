using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UsuarioAggregate;

namespace Zimat.Inventarios.UseCases.Usuarios.Create;

public class CreateUsuarioHandler(IRepository<Usuario> _repository)
  : ICommandHandler<CreateUsuarioCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateUsuarioCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new Usuario(request.Clave, request.Nombre, request.Email, request.Nivel, request.EsVendedor);
    newItem.User = request.UserName;
    newItem.Comision = request.Comision;
    newItem.ListaPrecio = request.ListaPrecio;

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}