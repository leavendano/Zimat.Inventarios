using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Marcas;
using Zimat.Inventarios.UseCases.Marcas.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;

public class ListMarcasQueryService(AppDbContext _db) : IListMarcasQueryService
{
    public async Task<IEnumerable<MarcaDTO>> ListAsync(int? skip, int? take)
    {
        var result = await _db.Database
            .SqlQuery<MarcaDTO>($"SELECT id, descripcion FROM marcas ORDER BY descripcion")
            .ToListAsync();

        return result;
    }
}
