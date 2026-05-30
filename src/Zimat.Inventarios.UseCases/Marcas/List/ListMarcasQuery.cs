using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Marcas.List;

public record ListMarcasQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<MarcaDTO>>>;
