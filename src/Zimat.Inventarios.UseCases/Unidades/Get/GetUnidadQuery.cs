using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Unidades.Get;
public record GetUnidadQuery(Guid UnidadId) : IQuery<Result<UnidadDTO>>;
