using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zimat.Inventarios.UseCases.Articulos;

namespace Zimat.Inventarios.UseCases.Proveedores.List;
public interface IListProveedoresQueryService
{
  Task<IEnumerable<ProveedorDTO>> ListAsync();
}
