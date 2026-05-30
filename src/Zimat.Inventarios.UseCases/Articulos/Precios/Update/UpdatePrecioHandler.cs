using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.Update;

public class UpdatePrecioHandler(IRepository<Articulo> _repository)
  : ICommandHandler<UpdatePrecioCommand, Result>
{
  public async Task<Result> Handle(UpdatePrecioCommand request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesAndPreciosSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound($"Artículo con Id {request.ArticuloId} no encontrado");

    var articuloUnidad = articulo.ArticuloUnidades.FirstOrDefault(au => au.Id == request.ArticuloUnidadId);
    if (articuloUnidad == null) return Result.NotFound($"No se encontró ArticuloUnidad con Id {request.ArticuloUnidadId}");

    var precio = articuloUnidad.Precios.FirstOrDefault(p => p.Id == request.PrecioId);
    if (precio == null) return Result.NotFound($"No se encontró Precio con Id {request.PrecioId}");

    try
    {
      precio.ImportePrecio = request.ImportePrecio;
      precio.FactorCosto = request.FactorCosto;
      precio.UpdatedAt = DateTime.UtcNow;
      await _repository.UpdateAsync(articulo, cancellationToken);
      return Result.Success();
    }
    catch (InvalidOperationException ex)
    {
      return Result.Error(ex.Message);
    }
  }
}
