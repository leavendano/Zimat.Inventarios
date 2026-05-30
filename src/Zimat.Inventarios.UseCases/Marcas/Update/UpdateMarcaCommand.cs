using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Marcas.Update;

public record UpdateMarcaCommand(Guid MarcaId, string Descripcion)
    : ICommand<Result<MarcaDTO>>;
