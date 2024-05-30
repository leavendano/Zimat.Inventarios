using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ContributorAggregate;
using Zimat.Inventarios.UseCases.Contributors.Create;

namespace Zimat.Inventarios.UseCases.Articulos.Create;
public class CreateArticuloHandler(IRepository<Articulo> _repository)
  : ICommandHandler<CreateArticuloCommand, Result<int>>
{
  public async Task<Result<int>> Handle(CreateArticuloCommand request,
    CancellationToken cancellationToken)
  {
    var newArticulo = new Articulo(request.Clave,request.Descripcion);
    if (!string.IsNullOrEmpty(request.Clave))
    {
      newArticulo.Codigo = request.Codigo;
    }
    var createdItem = await _repository.AddAsync(newArticulo, cancellationToken);

    return createdItem.Id;
  }
}



