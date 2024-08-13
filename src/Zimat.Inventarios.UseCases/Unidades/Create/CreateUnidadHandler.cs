using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UnidadAggregate;


namespace Zimat.Inventarios.UseCases.Unidades.Create;
public class CreateUnidadHandler(IRepository<Unidad> _repository)
  : ICommandHandler<CreateUnidadCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateUnidadCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new Unidad(request.Descripcion, request.ClaveSat,request.UserName);
  
    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}

