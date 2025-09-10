using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.UseCases.Articulos;
using Zimat.Inventarios.UseCases.Articulos.List;

namespace Zimat.Inventarios.Infrastructure.Data.Queries;

public class ListArticulosQueryService(AppDbContext _db) : IListArticulosQueryService
{
  // You can use EF, Dapper, SqlClient, etc. for queries -
  // this is just an example

  public async Task<IEnumerable<ArticuloListarDTO>> ListAsync(string? filtro, int? skip, int? take)
  {
    // NOTE: This will fail if testing with EF InMemory provider!
    var stringBuilder = new StringBuilder(@"SELECT a.id,clave , a.descripcion, a.precio_publico, a.costo_unitario as ultimo_costo, impuesto1, a.unidad_id,
          u.descripcion as unidad, stock_actual, ruta_imagen, 1 as cantidad  FROM articulos a LEFT JOIN public.unidades u ON u.id = a.unidad_id ");


    if (!String.IsNullOrEmpty(filtro))
    {
      stringBuilder.Append($" WHERE a.descripcion ILIKE '%{filtro}%' or a.clave ILIKE '%{filtro}%' ");
    }

    stringBuilder.Append("ORDER BY a.clave");
    if (skip.HasValue && skip.Value > 0)
    {
      stringBuilder.Append($" OFFSET {skip.Value}");
    }

    if (take.HasValue && take.Value > 0)
    {
      stringBuilder.Append($" LIMIT {take.Value}");
    }

    var query = FormattableStringFactory.Create(stringBuilder.ToString());
    var result = await _db.Database.SqlQuery<ArticuloListarDTO>(query).ToListAsync();

    return result;
  }




  public async Task<IEnumerable<ArticuloPrecioListarDTO>> ListPreciosAsync(string? filtro, int? skip, int? take)
  {
    // NOTE: This will fail if testing with EF InMemory provider!
    var stringBuilder = new StringBuilder(@"SELECT a.id,clave , a.descripcion, a.impuesto1, a.ruta_imagen, a.stock_actual,
          au.id as articulo_unidad_id, au.unidad_id,u.descripcion as nombre_unidad, p.numero_lista as noprecio, p.importe_precio 
          FROM articulos a 
          LEFT JOIN articulo_unidades au ON au.articulo_id = a.id
          LEFT JOIN precios p ON p.articulo_unidad_id = au.id
          LEFT JOIN unidades u ON u.id = au.unidad_id ");


    if (!String.IsNullOrEmpty(filtro))
    {
      stringBuilder.Append($" WHERE a.descripcion ILIKE '%{filtro}%' or a.clave ILIKE '%{filtro}%' ");
    }

    stringBuilder.Append(" ORDER BY a.id,au.id,p.numero_lista ");
    if (skip.HasValue && skip.Value > 0)
    {
      stringBuilder.Append($" OFFSET {skip.Value}");
    }

    if (take.HasValue && take.Value > 0)
    {
      stringBuilder.Append($" LIMIT {take.Value}");
    }

    var query = FormattableStringFactory.Create(stringBuilder.ToString());
    var result = await _db.Database.SqlQuery<ArticuloUnidadPrecioDTO>(query).ToListAsync();

    return AgruparResultados(result);
  }
  
  private List<ArticuloPrecioListarDTO> AgruparResultados(List<ArticuloUnidadPrecioDTO> dtos)
{
    return dtos
        .GroupBy(d => d.Id)
        .Select(g => new ArticuloPrecioListarDTO
        {
            Id = g.Key,
            Clave = g.First().Clave,
            Descripcion = g.First().Descripcion,
            Impuesto1 = g.First().Impuesto1,
            RutaImagen = g.First().RutaImagen,
            StockActual = g.First().StockActual,
            UnidadId = g.First().UnidadId,
            Cantidad = 1M,
            PrecioPublico = g.First().ImportePrecio ?? 0,
            Unidades = g
                .Where(x => x.ArticuloUnidadId.HasValue)
                .GroupBy(x => x.ArticuloUnidadId)
                .Select(ug => new ArticuloUnidadDTO
                {
                    Id = ug.Key,
                    ArticuloId = g.Key,
                    UnidadId = ug.First().UnidadId,
                    NombreUnidad = ug.First().NombreUnidad,
                    Precios = [.. ug
                        .Where(p => p.Noprecio.HasValue)
                        .Select(p => new Precio
                        {
                            NoLista = p.Noprecio!.Value,
                            ImportePrecio = p.ImportePrecio
                        })
                        .OrderBy(p => p.NoLista)]
                })
                .ToList()
        })
        .ToList();
}
}
