using System.Runtime.CompilerServices;
using System.Text;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.UnidadAggregate;
using Zimat.Inventarios.UseCases.Articulos;
using Zimat.Inventarios.UseCases.Articulos.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListArticulosQueryService(AppDbContext _db) : IListArticulosQueryService
{
  // You can use EF, Dapper, SqlClient, etc. for queries -
  // this is just an example

  public async Task<IEnumerable<ArticuloListarDTO>> ListAsync(string? filtro, int? skip, int? take)
  {
    // NOTE: This will fail if testing with EF InMemory provider!
    var stringBuilder = new StringBuilder("SELECT a.id,clave , a.descripcion, precio_publico, costo_unitario as ultimo_costo, impuesto1, u.descripcion as unidad, ruta_imagen  FROM articulos a LEFT JOIN public.unidades u ON u.id = a.unidad_id ");
    

    if (!String.IsNullOrEmpty(filtro))
    {
      stringBuilder.Append($" WHERE a.descripcion ILIKE '%{filtro}%' or a.clave ILIKE '%{filtro}%' ");
    }

    stringBuilder.Append("ORDER BY a.clave");
    if (skip.HasValue && skip.Value > 0)
    {
      stringBuilder.Append($" OFFSET {skip.Value}");
    }

    if(take.HasValue && take.Value > 0)
    {
      stringBuilder.Append($" LIMIT {take.Value}");
    }

    var query = FormattableStringFactory.Create(stringBuilder.ToString());
    var result = await _db.Database.SqlQuery<ArticuloListarDTO>(query).ToListAsync();

    return result;
  }
}
