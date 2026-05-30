using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.DepartamentoAggregate;


namespace Zimat.Inventarios.UseCases.Departamentos.Update;
public class UpdateDepartamentoHandler(IRepository<Departamento> _repository) :
    ICommandHandler<UpdateDepartamentoCommand, Result<DepartamentoDTO>>
{

  public async Task<Result<DepartamentoDTO>> Handle(UpdateDepartamentoCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.DepartamentoId, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }

    existingItem.UpdateNombre(request.Nombre!);


    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success(new DepartamentoDTO(existingItem.Id,
      existingItem.Nombre));
  }
}
