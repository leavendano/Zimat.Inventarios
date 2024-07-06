

namespace Zimat.Inventarios.UseCases.Documentos.List;
public interface IListDocumentosQueryService
{
  Task<IEnumerable<DocumentoDTO>> ListAsync();
}
