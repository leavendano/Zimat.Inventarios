using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Usuarios;
using Zimat.Inventarios.UseCases.Usuarios.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;

public class ListUsuariosQueryService(AppDbContext _db) : IListUsuariosQueryService
{
    public async Task<IEnumerable<UsuarioDTO>> ListAsync(string? filtro, int? Skip, int? Take)
 {
    var stringBuilder = new StringBuilder(@"SELECT id,clave , nombre, rfc, codigo_postal FROM Clientes ");


    if (!String.IsNullOrEmpty(filtro))
    {
        stringBuilder.Append($" WHERE nombre ILIKE '%{filtro}%' or clave ILIKE '%{filtro}%' ");
    }
    
    var query = FormattableStringFactory.Create(stringBuilder.ToString());
    var result = await _db.Database.SqlQuery<UsuarioDTO>(query) // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}