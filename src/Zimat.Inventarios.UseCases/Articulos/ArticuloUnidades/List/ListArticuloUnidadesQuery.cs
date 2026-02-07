using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.ArticuloUnidades.List;

public record ListArticuloUnidadesQuery(Guid ArticuloId) : IQuery<Result<IEnumerable<ArticuloUnidadListarDTO>>>;
