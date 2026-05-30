using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Lineas.Get;
public record GetLineaQuery(Guid LineaId) : IQuery<Result<LineaDTO>>;