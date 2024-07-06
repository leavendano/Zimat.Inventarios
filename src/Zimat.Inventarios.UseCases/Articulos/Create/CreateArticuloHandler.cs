using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;


namespace Zimat.Inventarios.UseCases.Articulos.Create;
public class CreateArticuloHandler(IRepository<Articulo> _repository)
  : ICommandHandler<CreateArticuloCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateArticuloCommand request,
    CancellationToken cancellationToken)
  {
    var newArticulo = new Articulo(request.Clave,request.Descripcion, request.PrecioPublico);

    var createdItem = await _repository.AddAsync(newArticulo, cancellationToken);

    return createdItem.Id;
  }
}



