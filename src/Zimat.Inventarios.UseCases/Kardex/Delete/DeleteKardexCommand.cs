using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Delete;

public record DeleteKardexCommand(Guid KardexId) : ICommand<Result>;
