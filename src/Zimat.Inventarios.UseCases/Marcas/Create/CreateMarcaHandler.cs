using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.MarcaAggregate;

namespace Zimat.Inventarios.UseCases.Marcas.Create;

public class CreateMarcaHandler(IRepository<Marca> _repository)
    : ICommandHandler<CreateMarcaCommand, Result<Guid>>
{
    public async Task<Result<Guid>> Handle(CreateMarcaCommand request, CancellationToken cancellationToken)
    {
        var newItem = new Marca(request.Descripcion, request.UserName);
        var createdItem = await _repository.AddAsync(newItem, cancellationToken);
        return createdItem.Id;
    }
}
