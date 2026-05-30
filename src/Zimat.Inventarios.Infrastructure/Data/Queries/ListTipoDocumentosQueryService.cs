using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.TipoDocumentos;
using Zimat.Inventarios.UseCases.TipoDocumentos.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;

public class ListTipoDocumentosQueryService(AppDbContext _db) : IListTipoDocumentosQueryService
{
  public async Task<IEnumerable<TipoDocumentoDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<TipoDocumentoDTO>(
     @$"SELECT id, nombre, es_entrada, es_salida,
        afecta_inventario, afecta_cuentas_por_pagar ,
        afecta_cuentas_por_cobrar , requiere_proveedor ,
        requiere_cliente , prefijo, ultimo_folio 
        FROM tipo_documentos ORDER BY nombre")
     .ToListAsync();

    return result;
  }
}
