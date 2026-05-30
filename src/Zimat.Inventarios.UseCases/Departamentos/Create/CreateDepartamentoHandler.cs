using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.DepartamentoAggregate;


namespace Zimat.Inventarios.UseCases.Departamentos.Create;
public class CreateDepartamentoHandler(IRepository<Departamento> _repository)
  : ICommandHandler<CreateDepartamentoCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateDepartamentoCommand request,
    CancellationToken cancellationToken)
  {
    var newItem = new Departamento(request.Nombre, request.UserName);

    var createdItem = await _repository.AddAsync(newItem, cancellationToken);

    return createdItem.Id;
  }
}
