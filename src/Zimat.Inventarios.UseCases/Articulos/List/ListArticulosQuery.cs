using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.List;
public record ListArticulosQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ArticuloDTO>>>;
