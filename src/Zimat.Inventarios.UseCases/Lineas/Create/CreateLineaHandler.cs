using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.LineaAggregate;


namespace Zimat.Inventarios.UseCases.Lineas.Create;
public class CreateLineaHandler(IRepository<Linea> _repository)
  : ICommandHandler<CreateLineaCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateLineaCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new Linea(request.Descripcion, request.Margen,request.UserName);
  
    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}
