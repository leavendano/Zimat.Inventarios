using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Clientes.List;

public record ListClientesQuery(string? filtro,int? Skip, int? Take) : IQuery<Result<IEnumerable<ClienteDTO>>>;