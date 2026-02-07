using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.List;

public class ListArticuloUnidadesHandler(IReadRepository<Articulo> _repository)
  : IQueryHandler<ListArticuloUnidadesQuery, Result<IEnumerable<ArticuloUnidadListarDTO>>>
{
  public async Task<Result<IEnumerable<ArticuloUnidadListarDTO>>> Handle(ListArticuloUnidadesQuery request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound();

    var articuloUnidades = articulo.ArticuloUnidades.Select(au => new ArticuloUnidadListarDTO
    {
      Id = au.Id,
      ArticuloId = au.ArticuloId,
      UnidadId = au.UnidadId,
      UnidadNombre = au.Unidad?.Descripcion,
      FactorConversion = au.FactorConversion,
      User = au.User,
      Status = au.Status,
      CreatedAt = au.CreatedAt,
      UpdatedAt = au.UpdatedAt
    });

    return Result.Success(articuloUnidades);
  }
}
