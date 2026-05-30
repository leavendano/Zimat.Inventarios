using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Ventas;
using Zimat.Inventarios.UseCases.Ventas.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListVentasQueryService(AppDbContext _db) : IListVentasQueryService
{
  public async Task<IEnumerable<VentaDTO>> ListAsync(Guid? ClienteId, int? TipoDocumentoId)
  {
    var result = await _db.Database.SqlQuery<VentaDTO>(
      $@"SELECT id, folio, fecha, tipo_documento_id, cliente_id, importe, pagado FROM ventas
      WHERE 1 = 1
      and ({ClienteId}::uuid is null or cliente_id = {ClienteId})
      and ({TipoDocumentoId}::int is null or tipo_documento_id = {TipoDocumentoId})")
      .ToListAsync();

    return result;
  }
}
