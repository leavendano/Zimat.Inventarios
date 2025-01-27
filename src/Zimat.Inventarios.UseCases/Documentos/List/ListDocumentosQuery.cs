using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Documentos.List;
public record ListDocumentosQuery(int? ProveedorId,int? TipoDocumentoId,int? Skip, int? Take) : IQuery<Result<IEnumerable<DocumentoDTO>>>;
