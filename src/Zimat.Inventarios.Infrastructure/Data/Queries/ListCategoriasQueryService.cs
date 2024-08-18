using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Categorias.List;
using Zimat.Inventarios.UseCases.Categorias;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListCategoriasQueryService(AppDbContext _db) : IListCategoriasQueryService
{
  public async Task<IEnumerable<CategoriaDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<CategoriaDTO>(
     $"SELECT id,descripcion,margen FROM categorias") // don't fetch other big columns
     .ToListAsync();

    return result;
  }
}

