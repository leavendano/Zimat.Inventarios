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
      and ( {ProveedorId}::uuid is null or proveedor_id = {ProveedorId})
      and ( {TipoDocumentoId}::int is null or tipo_documento_id = {TipoDocumentoId})") // don't fetch other big columns
      .ToListAsync();

    return result;
  }

  public async Task<IEnumerable<CompraListarDTO>> ListComprasAsync(Guid? ProveedorId, int? TipoDocumentoId)
  {
    var result = await _db.Database.SqlQuery<CompraListarDTO>(
      $@"SELECT c.id,c.folio , c.fecha, c.tipo_documento_id,td.nombre as tipo_documento_nombre , proveedor_id,p.nombre as proveedor_nombre, importe, documento_relacionado_id FROM compras c
        LEFT JOIN tipo_documentos td ON td.id = c.tipo_documento_id
        LEFT JOIN proveedores p ON p.id = c.proveedor_id
      WHERE 1= 1
      and ( {ProveedorId}::uuid is null or proveedor_id = {ProveedorId})
      and ( {TipoDocumentoId}::int is null or tipo_documento_id = {TipoDocumentoId})") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
