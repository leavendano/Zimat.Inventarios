using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Marcas.Get;

public record GetMarcaQuery(Guid MarcaId) : IQuery<Result<MarcaDTO>>;
