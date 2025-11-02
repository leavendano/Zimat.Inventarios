using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.List;

public record ListTipoDocumentosQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<TipoDocumentoDTO>>>;
