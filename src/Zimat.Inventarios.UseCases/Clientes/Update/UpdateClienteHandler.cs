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
    existingItem.Calle = request.Calle;
    existingItem.NumeroExterior = request.NumeroExterior;
    existingItem.Colonia = request.Colonia;
    existingItem.Ciudad = request.Ciudad;
    existingItem.Estado = request.Estado;
    existingItem.Pais = request.Pais;
    existingItem.Telefono = request.Telefono;
    existingItem.Email = request.Email;
    existingItem.ContactoVentas = request.ContactoVentas;
    existingItem.ContactoPago = request.ContactoPago;
    existingItem.RegimenFiscal = request.RegimenFiscal;
    existingItem.UsoCfdi = request.UsoCfdi;
    existingItem.Observaciones = request.Observaciones;
    existingItem.DiasCredito = request.DiasCredito;
    existingItem.LimiteCredito = request.LimiteCredito;
    existingItem.UpdatedAt = DateTime.UtcNow;

    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success();
  }
}
