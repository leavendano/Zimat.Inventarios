
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Unidades;
using Zimat.Inventarios.UseCases.Unidades.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListUnidadesQueryService(AppDbContext _db) : IListUnidadesQueryService
{
  public async Task<IEnumerable<UnidadDTO>> ListAsync()
  {
     var result = await _db.Database.SqlQuery<UnidadDTO>(
      $"SELECT id,descripcion, clave_sat FROM unidades") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
