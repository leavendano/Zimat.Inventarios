using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Lineas.Delete;

public record DeleteLineaCommand(Guid LineaId) : ICommand<Result>;