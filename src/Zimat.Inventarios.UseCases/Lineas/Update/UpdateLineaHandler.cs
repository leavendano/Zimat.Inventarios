using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.LineaAggregate;


namespace Zimat.Inventarios.UseCases.Lineas.Update;
public class UpdateLineaHandler(IRepository<Linea> _repository) : 
    ICommandHandler<UpdateLineaCommand, Result<LineaDTO>>
{

  public async Task<Result<LineaDTO>> Handle(UpdateLineaCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.LineaId, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }
    
    existingItem.UpdateDescripcion(request.Descripcion!);
    existingItem.UpdateMargen(request.Margen);
    
   
    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success(new LineaDTO(existingItem.Id,
      existingItem.Descripcion,existingItem.Margen));
  }
}