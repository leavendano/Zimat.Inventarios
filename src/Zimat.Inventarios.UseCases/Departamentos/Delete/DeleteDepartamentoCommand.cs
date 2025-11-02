using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Departamentos.Delete;

public record DeleteDepartamentoCommand(Guid DepartamentoId) : ICommand<Result>;
