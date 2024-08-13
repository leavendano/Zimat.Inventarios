using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UnidadAggregate;
using Zimat.Inventarios.Core.UnidadAggregate.Specifications;
using Zimat.Inventarios.UseCases.Unidades;
using Zimat.Inventarios.UseCases.Unidades.Get;


namespace Zimat.Inventarios.UseCases.Articulos.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetUnidadHandler(IReadRepository<Unidad> _repository)
  : IQueryHandler<GetUnidadQuery, Result<UnidadDTO>>
{
  public async Task<Result<UnidadDTO>> Handle(GetUnidadQuery request, CancellationToken cancellationToken)
  {
    var spec = new UnidadByIdSpec(request.UnidadId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new UnidadDTO(entity.Id,entity.Descripcion, entity.ClaveSat);
  }
}
