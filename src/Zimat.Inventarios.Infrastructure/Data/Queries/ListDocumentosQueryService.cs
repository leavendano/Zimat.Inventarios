using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Documentos;
using Zimat.Inventarios.UseCases.Documentos.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListDocumentosQueryService(AppDbContext _db) : IListDocumentosQueryService
{
  public async Task<IEnumerable<DocumentoDTO>> ListAsync(int? ProveedorId, int? TipoDocumentoId)
  {
    var result = await _db.Database.SqlQuery<DocumentoDTO>(
      $@"SELECT id,folio , fecha, tipo_documento_id, cliente_id, proveedor_id, importe, documento_relacionado_id FROM documentos
      WHERE 1= 1 
      and ( {ProveedorId}::int is null or proveedor_id >= {ProveedorId})
      and ( {TipoDocumentoId}::int is null or tipo_documento_id >= {TipoDocumentoId})") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
