using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zimat.Inventarios.UseCases.Familias;

namespace Zimat.Inventarios.UseCases.Categorias.List;
public interface IListCategoriasQueryService
{
  Task<IEnumerable<CategoriaDTO>> ListAsync();
}
