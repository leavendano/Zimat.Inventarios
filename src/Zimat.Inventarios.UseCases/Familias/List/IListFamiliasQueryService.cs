using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zimat.Inventarios.UseCases.Lineas;

namespace Zimat.Inventarios.UseCases.Familias.List;
public interface IListFamiliasQueryService
{
  Task<IEnumerable<FamiliaDTO>> ListAsync();
}
