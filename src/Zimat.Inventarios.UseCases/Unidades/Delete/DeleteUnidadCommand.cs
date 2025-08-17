using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Unidades.Delete;

public record DeleteUnidadCommand(Guid UnidadId) : ICommand<Result>;
