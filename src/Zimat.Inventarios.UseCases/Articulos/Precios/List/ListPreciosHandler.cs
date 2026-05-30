using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.List;

public class ListPreciosHandler(IReadRepository<Articulo> _repository)
  : IQueryHandler<ListPreciosQuery, Result<IEnumerable<PrecioListarDTO>>>
{
  public async Task<Result<IEnumerable<PrecioListarDTO>>> Handle(ListPreciosQuery request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesAndPreciosSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound();

    var articuloUnidad = articulo.ArticuloUnidades.FirstOrDefault(au => au.Id == request.ArticuloUnidadId);
    if (articuloUnidad == null) return Result.NotFound();

    var precios = articuloUnidad.Precios.Select(p => new PrecioListarDTO
    {
      Id = p.Id,
      ArticuloUnidadId = p.ArticuloUnidadId,
      NumeroLista = p.NumeroLista,
      ImportePrecio = p.ImportePrecio,
      FactorCosto = p.FactorCosto,
      User = p.User,
      Status = p.Status,
      CreatedAt = p.CreatedAt,
      UpdatedAt = p.UpdatedAt
    });

    return Result.Success(precios);
  }
}
