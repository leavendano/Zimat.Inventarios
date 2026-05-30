using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.Update;

public class UpdateArticuloUnidadHandler(IRepository<Articulo> _repository)
  : ICommandHandler<UpdateArticuloUnidadCommand, Result>
{
  public async Task<Result> Handle(UpdateArticuloUnidadCommand request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound($"Artículo con Id {request.ArticuloId} no encontrado");

    try
    {
      articulo.UpdateArticuloUnidad(request.ArticuloUnidadId, request.FactorConversion);
      await _repository.UpdateAsync(articulo, cancellationToken);
      return Result.Success();
    }
    catch (InvalidOperationException ex)
    {
      return Result.Error(ex.Message);
    }
  }
}
