using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Articulos.List;
using Zimat.Inventarios.UseCases.Articulos;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListArticulosQueryService(AppDbContext _db) : IListArticulosQueryService
{
  // You can use EF, Dapper, SqlClient, etc. for queries -
  // this is just an example

  public async Task<IEnumerable<ArticuloDTO>> ListAsync()
  {
    // NOTE: This will fail if testing with EF InMemory provider!
    var result = await _db.Database.SqlQuery<ArticuloDTO>(
      $"SELECT id,clave , descripcion, precio_publico FROM Articulos") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
