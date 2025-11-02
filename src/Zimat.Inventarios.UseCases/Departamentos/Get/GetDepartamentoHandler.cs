using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.DepartamentoAggregate;
using Zimat.Inventarios.Core.DepartamentoAggregate.Specifications;
using Zimat.Inventarios.UseCases.Departamentos;
using Zimat.Inventarios.UseCases.Departamentos.Get;


namespace Zimat.Inventarios.UseCases.Departamentos.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetDepartamentoHandler(IReadRepository<Departamento> _repository)
  : IQueryHandler<GetDepartamentoQuery, Result<DepartamentoDTO>>
{
  public async Task<Result<DepartamentoDTO>> Handle(GetDepartamentoQuery request, CancellationToken cancellationToken)
  {
    var spec = new DepartamentoByIdSpec(request.DepartamentoId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new DepartamentoDTO(entity.Id, entity.Nombre);
  }
}
