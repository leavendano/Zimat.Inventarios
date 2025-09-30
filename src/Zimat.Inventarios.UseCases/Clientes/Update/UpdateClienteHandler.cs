using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ClienteAggregate;

namespace Zimat.Inventarios.UseCases.Clientes.Update;

public class UpdateClienteHandler(IRepository<Cliente> _repository) :
    ICommandHandler<UpdateClienteCommand, Result>
{
  public async Task<Result> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.Id, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }

    existingItem.UpdateClave(request.Clave);
    existingItem.UpdateNombre(request.Nombre);
    existingItem.UpdateRfc(request.Rfc);
    existingItem.UpdateCodigoPostal(request.CodigoPostal);
    existingItem.UpdatedAt = DateTime.UtcNow;

    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success();
  }
}