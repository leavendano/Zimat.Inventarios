using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Articulos.Get;
public record GetArticuloQuery(int ArticuloId) : IQuery<Result<ArticuloDTO>>;
