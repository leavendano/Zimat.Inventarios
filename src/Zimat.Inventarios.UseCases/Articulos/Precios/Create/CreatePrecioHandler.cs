using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;
using PrecioEntity = Zimat.Inventarios.Core.ArticuloAggregate.Precio;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.Create;

public class CreatePrecioHandler(IRepository<Articulo> _repository)
  : ICommandHandler<CreatePrecioCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreatePrecioCommand request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdWithUnidadesAndPreciosSpec(request.ArticuloId);
    var articulo = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

    if (articulo == null) return Result.NotFound($"Artículo con Id {request.ArticuloId} no encontrado");

    var nuevoPrecio = new PrecioEntity(
      request.ArticuloUnidadId,
      request.NumeroLista,
      request.ImportePrecio,
      request.FactorCosto,
      request.UserName ?? "ADMINISTRADOR",
      null
    );

    try
    {
      articulo.AddPrecioToUnidad(request.ArticuloUnidadId, nuevoPrecio);
      await _repository.SaveChangesAsync(cancellationToken);
      return Result.Success(nuevoPrecio.Id);
    }
    catch (InvalidOperationException ex)
    {
      return Result.Error(ex.Message);
    }
  }
}
