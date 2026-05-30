using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Proveedores.Get;

public record GetProveedorQuery(Guid ProveedorId) : Ardalis.SharedKernel.IQuery<Result<ProveedorDTO>>;
