using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Delete;

public record DeleteTipoDocumentoCommand(int TipoDocumentoId) : ICommand<Result>;
