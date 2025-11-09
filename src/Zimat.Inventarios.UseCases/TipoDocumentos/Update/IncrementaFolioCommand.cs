using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Update;
public record IncrementaFolioCommand(int TipoDocumentoId) : ICommand<Result<TipoDocumentoDTO>>;

