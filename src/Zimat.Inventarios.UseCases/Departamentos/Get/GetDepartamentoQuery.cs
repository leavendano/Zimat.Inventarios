using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Departamentos.Get;
public record GetDepartamentoQuery(Guid DepartamentoId) : IQuery<Result<DepartamentoDTO>>;
