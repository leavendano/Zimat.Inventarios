using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Clientes.Delete;

public record DeleteClienteCommand(Guid ClienteId) : ICommand<Result>;