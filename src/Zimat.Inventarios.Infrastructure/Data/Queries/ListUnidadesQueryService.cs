
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Unidades;
using Zimat.Inventarios.UseCases.Unidades.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListUnidadesQueryService(AppDbContext _db) : IListUnidadesQueryService
{
  public async Task<IEnumerable<UnidadDTO>> ListAsync(Guid? articuloId,int? skip, int? take)
  {
    var sqlQuery = $@"SELECT u.id,u.descripcion, u.clave_sat FROM unidades  u
      {(articuloId.HasValue ? " JOIN articulo_unidades a ON a.unidad_id = u.id WHERE a.articulo_id = {articulo_id}" : "")}
         ORDER BY u.descripcion";

     var formatString = FormattableStringFactory.Create(sqlQuery);
     var result = await _db.Database.SqlQuery<UnidadDTO>(formatString)
      .ToListAsync();

    return result;
  }
}
