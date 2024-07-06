using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Proveedores;
using Zimat.Inventarios.UseCases.Proveedores.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListProveedoresQueryService(AppDbContext _db) : IListProveedoresQueryService
{
  public async Task<IEnumerable<ProveedorDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<ProveedorDTO>(
      $"SELECT id,clave , nombre, rfc, codigo_postal FROM Proveedores") // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}
