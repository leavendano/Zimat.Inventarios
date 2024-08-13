using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Unidades.Delete;

public record DeleteUnidadCommand(int UnidadId) : ICommand<Result>;
