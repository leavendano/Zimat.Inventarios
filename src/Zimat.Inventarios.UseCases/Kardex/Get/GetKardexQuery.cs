using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.Get;

public record GetKardexQuery(Guid KardexId) : IQuery<Result<KardexDTO>>;
