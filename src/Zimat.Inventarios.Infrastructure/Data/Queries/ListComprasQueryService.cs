using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Compras;
using Zimat.Inventarios.UseCases.Compras.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListComprasQueryService(AppDbContext _db) : IListComprasQueryService
{
  public async Task<IEnumerable<CompraDTO>> ListAsync(Guid? ProveedorId, int? TipoDocumentoId)
  {
    var result = await _db.Database.SqlQuery<CompraDTO>(
      $@"SELECT id,folio , fecha, tipo_documento_id, proveedor_id, importe, documento_relacionado_id FROM compras
      WHERE 1= 1
      and ( {ProveedorId}::int is null or proveedor_id >= {ProveedorId})
      and ( {TipoDocumentoId}::int is null or tipo_documento_id >= {TipoDocumentoId})") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
