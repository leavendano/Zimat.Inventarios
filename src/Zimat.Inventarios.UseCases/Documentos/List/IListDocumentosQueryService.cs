

namespace Zimat.Inventarios.UseCases.Documentos.List;
public interface IListDocumentosQueryService
{
  Task<IEnumerable<DocumentoDTO>> ListAsync(int? ProveedorId,int? TipoDocumentoId);

  //Task<IEnumerable<DocumentoDTO>> ListPorProveedorAsync(int ProveedorId,int TipoDocumentoId);
}
