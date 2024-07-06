using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.UseCases.Articulos;

namespace Zimat.Inventarios.UseCases.Proveedores.List;
public record ListProveedoresQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ProveedorDTO>>>;
