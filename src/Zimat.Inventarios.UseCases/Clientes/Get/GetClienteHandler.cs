using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ClienteAggregate;
using Zimat.Inventarios.Core.ClienteAggregate.Specifications;

namespace Zimat.Inventarios.UseCases.Clientes.Get;

public class GetClienteHandler(IReadRepository<Cliente> _repository)
  : IQueryHandler<GetClienteQuery, Result<ClienteDTO>>
{
  public async Task<Result<ClienteDTO>> Handle(GetClienteQuery request, CancellationToken cancellationToken)
  {
    var spec = new ClienteByIdSpec(request.ClienteId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new ClienteDTO(entity.Id, entity.Clave, entity.Nombre, entity.Rfc, entity.CodigoPostal);
  }
}