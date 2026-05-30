using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.FamiliaAggregate;


namespace Zimat.Inventarios.UseCases.Familias.Create;
public class CreateFamiliaHandler(IRepository<Familia> _repository)
  : ICommandHandler<CreateFamiliaCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateFamiliaCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new Familia(request.Descripcion, request.Margen, request.UserName);

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}
