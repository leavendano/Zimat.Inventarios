
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Departamentos.List;
using Zimat.Inventarios.UseCases.Departamentos;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListDepartamentosQueryService(AppDbContext _db) : IListDepartamentosQueryService
{
  public async Task<IEnumerable<DepartamentoDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<DepartamentoDTO>(
     $"SELECT id,nombre FROM departamentos") // don't fetch other big columns
     .ToListAsync();

    return result;
  }
}

