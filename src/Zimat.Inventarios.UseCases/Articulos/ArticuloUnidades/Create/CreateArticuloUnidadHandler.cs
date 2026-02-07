using Ardalis.Result;
using Ardalis.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.Create;

public class CreateArticuloUnidadHandler(IRepository<Articulo> _repository)
  : ICommandHandler<CreateArticuloUnidadCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateArticuloUnidadCommand request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound($"Artículo con Id {request.ArticuloId} no encontrado");

    var newArticuloUnidad = new ArticuloUnidad(
      request.ArticuloId,
      request.UnidadId,
      request.FactorConversion
    );

    newArticuloUnidad.User = request.UserName;

    try
    {
      articulo.AddArticuloUnidad(newArticuloUnidad);
      //await _repository.UpdateAsync(articulo, cancellationToken);
      await _repository.SaveChangesAsync(cancellationToken);
      return Result.Success(newArticuloUnidad.Id);
    }
    catch (InvalidOperationException ex)
    {
      return Result.Error(ex.Message);
    }
  }
}
