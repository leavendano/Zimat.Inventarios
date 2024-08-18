using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Documentos;
using Zimat.Inventarios.UseCases.Documentos.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListDocumentosQueryService(AppDbContext _db) : IListDocumentosQueryService
{
  public async Task<IEnumerable<DocumentoDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<DocumentoDTO>(
      $"SELECT id,folio , fecha, tipo_documento_id, cliente_id, proveedor_id, importe FROM documentos") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
