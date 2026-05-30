using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Departamentos.Create;

  public record CreateDepartamentoCommand(string Nombre,
        string UserName = "ADMINISTRADOR") : Ardalis.SharedKernel.ICommand<Result<Guid>>;
