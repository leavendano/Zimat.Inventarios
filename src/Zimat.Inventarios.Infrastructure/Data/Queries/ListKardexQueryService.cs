using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Kardex;
using Zimat.Inventarios.UseCases.Kardex.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;


public class ListKardexQueryService(AppDbContext _db) : IListKardexQueryService
{
  public async Task<IEnumerable<KardexListarDTO>> ListAsync(Guid? articuloId, int? almacenId, int? skip, int? take)
  {
    FormattableString part1 = $"";
    if (take.HasValue && take.Value > 0)
    {
       part1 =  $"LIMIT {take }";// Treat non-positive values as no limit
    }
    
    
    var result = await _db.Database.SqlQuery<KardexListarDTO>(
     $@"SELECT id,articuloid,almacenid,fecha,tipo,cantidad,precio FROM kardex 
    WHERE ({articuloId} IS NULL OR articuloid = {articuloId}) 
     AND ({almacenId} IS NULL OR almacenid = {almacenId}) ORDER BY fecha DESC OFFSET {skip ?? 0}  {part1}")
     .ToListAsync();

    return result;
  }
}