using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ProveedorAggregate;

namespace Zimat.Inventarios.UseCases.Proveedores.Create;


public class CreateProveedorHandler(IRepository<Proveedor> _repository) : ICommandHandler<CreateProveedorCommand, Result<Guid>>
{

    public async Task<Result<Guid>> Handle(CreateProveedorCommand request,
    CancellationToken cancellationToken)
  {
    
    var createdItem = await _repository.AddAsync(request.proveedor.ToProveedor(), cancellationToken);

    return createdItem.Id;
  }
}