using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Proveedores.Create;

 public record CreateProveedorCommand(ProveedorCrearDTO proveedor) : Ardalis.SharedKernel.ICommand<Result<Guid>>;