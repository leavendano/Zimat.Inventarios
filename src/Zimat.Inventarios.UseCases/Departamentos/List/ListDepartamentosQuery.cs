using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Departamentos.List;
public record ListDepartamentosQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<DepartamentoDTO>>>;

