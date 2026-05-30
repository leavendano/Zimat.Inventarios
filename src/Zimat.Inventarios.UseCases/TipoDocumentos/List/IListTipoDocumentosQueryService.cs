namespace Zimat.Inventarios.UseCases.TipoDocumentos.List;

public interface IListTipoDocumentosQueryService
{
  Task<IEnumerable<TipoDocumentoDTO>> ListAsync();
}
