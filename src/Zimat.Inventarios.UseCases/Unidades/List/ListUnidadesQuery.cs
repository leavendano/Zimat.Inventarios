using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Unidades.List;
public record ListUnidadesQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<UnidadDTO>>>;