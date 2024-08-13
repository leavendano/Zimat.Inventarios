using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate;



namespace Zimat.Inventarios.UseCases.Articulos.Create;
public class CreateArticuloHandler(IRepository<Articulo> _repository)
  : ICommandHandler<CreateArticuloCommand, Result<Guid>>
{
  public async Task<Result<Guid>> Handle(CreateArticuloCommand request,
    CancellationToken cancellationToken)
  {
    var newArticulo = new Articulo(request.Clave,request.Descripcion, request.PrecioPublico,request.UnidadId,request.UserName);
  
    var createdItem = await _repository.AddAsync(newArticulo, cancellationToken);

    return createdItem.Id;
  }
}



