using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Unidades.List;
public record ListUnidadesQuery(Guid? articuloId,int? Skip, int? Take) : IQuery<Result<IEnumerable<UnidadDTO>>>;