using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.UnidadAggregate;


namespace Zimat.Inventarios.UseCases.Unidades.Update;
public class UpdateUnidadHandler(IRepository<Unidad> _repository) : 
    ICommandHandler<UpdateUnidadCommand, Result<UnidadDTO>>
{

  public async Task<Result<UnidadDTO>> Handle(UpdateUnidadCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.UnidadId, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }
    
    existingItem.UpdateDescripcion(request.Descripcion!);
    existingItem.UpdateClaveSat(request.ClaveSat);
    
   
    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success(new UnidadDTO(existingItem.Id,
      existingItem.Descripcion,existingItem.ClaveSat));
  }
}
