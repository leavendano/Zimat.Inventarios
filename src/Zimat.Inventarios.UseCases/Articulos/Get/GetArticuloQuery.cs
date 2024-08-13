using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Articulos.Get;
public record GetArticuloQuery(Guid ArticuloId) : IQuery<Result<ArticuloDTO>>;
