using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.UseCases.Lineas;
using Zimat.Inventarios.UseCases.Lineas.List;
using Zimat.Inventarios.UseCases.Unidades;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;
public class ListLineasQueryService(AppDbContext _db) : IListLineasQueryService
{
  public async Task<IEnumerable<LineaDTO>> ListAsync()
  {
   
    var result = await _db.Database.SqlQuery<LineaDTO>(
     @$"SELECT id,descripcion, margen FROM lineas WHERE status = 1") // don't fetch other big columns
     .ToListAsync();

    return result;
  }
}
