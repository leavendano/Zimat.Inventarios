using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAgrregate.Specifications;


namespace Zimat.Inventarios.UseCases.Articulos.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetArticuloHandler(IReadRepository<Articulo> _repository)
  : IQueryHandler<GetArticuloQuery, Result<ArticuloDTO>>
{
  public async Task<Result<ArticuloDTO>> Handle(GetArticuloQuery request, CancellationToken cancellationToken)
  {
    var spec = new ArticuloByIdSpec(request.ArticuloId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new ArticuloDTO(entity.Id,entity.Clave, entity.Descripcion, entity.PrecioPublico,entity.UltimoCosto,entity.Impuesto1,"");
  }
}
