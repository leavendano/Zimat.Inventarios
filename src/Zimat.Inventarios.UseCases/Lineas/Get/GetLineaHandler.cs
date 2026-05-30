using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.LineaAggregate;
using Zimat.Inventarios.Core.LineaAggregate.Specifications;
using Zimat.Inventarios.UseCases.Lineas;
using Zimat.Inventarios.UseCases.Lineas.Get;


namespace Zimat.Inventarios.UseCases.Lineas.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetLineaHandler(IReadRepository<Linea> _repository)
  : IQueryHandler<GetLineaQuery, Result<LineaDTO>>
{
  public async Task<Result<LineaDTO>> Handle(GetLineaQuery request, CancellationToken cancellationToken)
  {
    var spec = new LineaByIdSpec(request.LineaId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new LineaDTO(entity.Id,entity.Descripcion, entity.Margen);
  }
}