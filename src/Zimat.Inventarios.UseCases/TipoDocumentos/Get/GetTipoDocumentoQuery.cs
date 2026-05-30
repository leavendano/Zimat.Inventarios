using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Get;

public record GetTipoDocumentoQuery(int TipoDocumentoId) : IQuery<Result<TipoDocumentoDTO>>;
