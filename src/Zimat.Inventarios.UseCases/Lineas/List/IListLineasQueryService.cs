using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zimat.Inventarios.UseCases.Unidades;

namespace Zimat.Inventarios.UseCases.Lineas.List;
public interface IListLineasQueryService
{
  Task<IEnumerable<LineaDTO>> ListAsync();
}
