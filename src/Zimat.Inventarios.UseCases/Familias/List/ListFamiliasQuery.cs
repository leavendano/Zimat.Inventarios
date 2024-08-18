using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.UseCases.Lineas;

namespace Zimat.Inventarios.UseCases.Familias.List;
public record ListFamiliasQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<FamiliaDTO>>>;

