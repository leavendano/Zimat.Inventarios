using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.UseCases.Departamentos.Update;
public record UpdateDepartamentoCommand(Guid DepartamentoId, string Nombre) : ICommand<Result<DepartamentoDTO>>;
