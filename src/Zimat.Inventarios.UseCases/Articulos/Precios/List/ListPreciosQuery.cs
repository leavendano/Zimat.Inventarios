using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Precios.List;

public record ListPreciosQuery(Guid ArticuloId, Guid ArticuloUnidadId)
  : IQuery<Result<IEnumerable<PrecioListarDTO>>>;
