using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Clientes.Get;

public record GetClienteQuery(Guid ClienteId) : IQuery<Result<ClienteDTO>>;