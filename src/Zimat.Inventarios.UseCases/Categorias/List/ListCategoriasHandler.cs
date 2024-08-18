using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.UseCases.Familias.List;
using Zimat.Inventarios.UseCases.Familias;

namespace Zimat.Inventarios.UseCases.Categorias.List;
public class ListCategoriasHandler(IListCategoriasQueryService _query) : IQueryHandler<ListCategoriasQuery, Result<IEnumerable<CategoriaDTO>>>
{
  public async Task<Result<IEnumerable<CategoriaDTO>>> Handle(ListCategoriasQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}


