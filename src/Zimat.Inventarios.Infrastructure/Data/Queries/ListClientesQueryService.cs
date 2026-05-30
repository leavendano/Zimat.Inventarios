using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Clientes;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;

public class ListClientesQueryService(AppDbContext _db) : IListClientesQueryService
{
  public async Task<IEnumerable<ClienteDTO>> ListAsync(string? filtro, int? Skip, int? Take)
 {
    var stringBuilder = new StringBuilder(@"SELECT id,clave , nombre, rfc, codigo_postal, 
            calle, numero_exterior,colonia, ciudad , estado, pais, telefono, email, contacto_ventas, contacto_pago,
            regimen_fiscal, uso_cfdi, observaciones, dias_credito, limite_credito  FROM Clientes ");


    if (!String.IsNullOrEmpty(filtro))
    {
        stringBuilder.Append($" WHERE nombre ILIKE '%{filtro}%' or clave ILIKE '%{filtro}%' ");
    }
    
    var query = FormattableStringFactory.Create(stringBuilder.ToString());
    var result = await _db.Database.SqlQuery<ClienteDTO>(query) // don't fetch other big columns
      .ToListAsync();

    return result;
  }
}