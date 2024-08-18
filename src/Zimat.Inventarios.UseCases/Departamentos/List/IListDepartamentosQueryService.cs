using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zimat.Inventarios.UseCases.Familias;

namespace Zimat.Inventarios.UseCases.Departamentos.List;
public interface IListDepartamentosQueryService
{
  Task<IEnumerable<DepartamentoDTO>> ListAsync();
}
