using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ProveedorAggregate;

namespace Zimat.Inventarios.UseCases.Proveedores.Update;

public class UpdateProveedorHandler(IRepository<Proveedor> _repository)
  : ICommandHandler<UpdateProveedorCommand, Result>
{
  public async Task<Result> Handle(UpdateProveedorCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.Id, cancellationToken);
    if (existingItem == null) return Result.NotFound();

    existingItem.UpdateClave(request.Clave);
    existingItem.UpdateNombre(request.Nombre);
    existingItem.UpdateRfc(request.Rfc);
    existingItem.UpdateCodigoPostal(request.CodigoPostal);
    existingItem.Calle = request.Calle;
    existingItem.NumeroExterior = request.NumeroExterior;
    existingItem.Colonia = request.Colonia;
    existingItem.Ciudad = request.Ciudad;
    existingItem.Estado = request.Estado;
    existingItem.Telefono = request.Telefono;
    existingItem.Email = request.Email;
    existingItem.Clasificacion = request.Clasificacion;
    existingItem.Contacto = request.Contacto;
    existingItem.CuentaContable = request.CuentaContable;
    existingItem.DiasCredito = request.DiasCredito;
    existingItem.TipoProveedor = request.TipoProveedor;
    existingItem.UpdatedAt = DateTime.UtcNow;

    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success();
  }
}
