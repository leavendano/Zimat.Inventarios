using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Kardex.List;

public record ListKardexQuery(Guid? ArticuloId, int? AlmacenId, int? Skip, int? Take)
    : IQuery<Result<IEnumerable<KardexListarDTO>>>;
