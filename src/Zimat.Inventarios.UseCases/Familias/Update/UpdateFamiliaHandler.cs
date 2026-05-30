using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.FamiliaAggregate;


namespace Zimat.Inventarios.UseCases.Familias.Update;
public class UpdateFamiliaHandler(IRepository<Familia> _repository) :
    ICommandHandler<UpdateFamiliaCommand, Result<FamiliaDTO>>
{

  public async Task<Result<FamiliaDTO>> Handle(UpdateFamiliaCommand request, CancellationToken cancellationToken)
  {
    var existingItem = await _repository.GetByIdAsync(request.FamiliaId, cancellationToken);
    if (existingItem == null)
    {
      return Result.NotFound();
    }

    existingItem.UpdateDescripcion(request.Descripcion!);
    existingItem.UpdateMargen(request.Margen);


    await _repository.UpdateAsync(existingItem, cancellationToken);

    return Result.Success(new FamiliaDTO(existingItem.Id,
      existingItem.Descripcion, existingItem.Margen));
  }
}
