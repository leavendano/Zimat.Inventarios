using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Marcas.Create;

public record CreateMarcaCommand(string Descripcion, string UserName = "ADMINISTRADOR")
    : ICommand<Result<Guid>>;
