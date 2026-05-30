using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Proveedores.Delete;
public record DeleteProveedorCommand(Guid ProveedorId) : ICommand<Result>;
