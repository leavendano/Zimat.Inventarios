using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Familias.List;
using Zimat.Inventarios.UseCases.Familias;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListFamiliasQueryService(AppDbContext _db) : IListFamiliasQueryService
{
  public async Task<IEnumerable<FamiliaDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<FamiliaDTO>(
     $"SELECT id,descripcion, margen FROM familias WHERE estatus = 1") // don't fetch other big columns
     .ToListAsync();

    return result;
  }
}
