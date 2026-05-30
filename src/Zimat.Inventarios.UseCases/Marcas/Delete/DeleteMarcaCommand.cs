using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Marcas.Delete;

public record DeleteMarcaCommand(Guid MarcaId) : ICommand<Result>;
