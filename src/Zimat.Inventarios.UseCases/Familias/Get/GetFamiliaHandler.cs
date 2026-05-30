using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.FamiliaAggregate;
using Zimat.Inventarios.Core.FamiliaAggregate.Specifications;
using Zimat.Inventarios.UseCases.Familias;
using Zimat.Inventarios.UseCases.Familias.Get;


namespace Zimat.Inventarios.UseCases.Familias.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetFamiliaHandler(IReadRepository<Familia> _repository)
  : IQueryHandler<GetFamiliaQuery, Result<FamiliaDTO>>
{
  public async Task<Result<FamiliaDTO>> Handle(GetFamiliaQuery request, CancellationToken cancellationToken)
  {
    var spec = new FamiliaByIdSpec(request.FamiliaId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new FamiliaDTO(entity.Id, entity.Descripcion, entity.Margen);
  }
}
