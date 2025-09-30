using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ClienteAggregate;

namespace Zimat.Inventarios.UseCases.Clientes.Create;

public class CreateClienteHandler(IRepository<Cliente> _repository)
  : ICommandHandler<CreateClienteCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateClienteCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new Cliente(request.Clave, request.Nombre, request.Rfc, request.CodigoPostal);
    newItem.User = request.UserName;

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}