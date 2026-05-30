using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.Delete;

public class DeletePrecioHandler(IRepository<Articulo> _repository)
  : ICommandHandler<DeletePrecioCommand, Result>
{
  public async Task<Result> Handle(DeletePrecioCommand request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesAndPreciosSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound($"Artículo con Id {request.ArticuloId} no encontrado");

    try
    {
      articulo.RemovePrecioFromUnidad(request.ArticuloUnidadId, request.PrecioId);
      await _repository.UpdateAsync(articulo, cancellationToken);
      return Result.Success();
    }
    catch (InvalidOperationException ex)
    {
      return Result.Error(ex.Message);
    }
  }
}
