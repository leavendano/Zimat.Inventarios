using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ProveedorAggregate;
using Zimat.Inventarios.Core.ProveedorAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Proveedores.Get;

public class GetProveedorHandler(IReadRepository<Proveedor> _repository)
  : IQueryHandler<GetProveedorQuery, Result<ProveedorDTO>>
{
  public async Task<Result<ProveedorDTO>> Handle(GetProveedorQuery request, CancellationToken cancellationToken)
  {
    var spec = new ProveedorByIdSpec(request.ProveedorId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new ProveedorDTO(
      entity.Id, entity.Clave, entity.Nombre, entity.Rfc, entity.CodigoPostal,
      entity.Calle, entity.NumeroExterior, entity.Colonia, entity.Ciudad, entity.Estado,
      entity.Telefono, entity.Email, entity.Clasificacion, entity.Contacto, entity.CuentaContable,
      entity.DiasCredito, entity.TipoProveedor
    );
  }
}
