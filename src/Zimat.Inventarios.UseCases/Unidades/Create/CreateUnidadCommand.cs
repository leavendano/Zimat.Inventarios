using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Unidades.Create;

  public record CreateUnidadCommand(string Descripcion, string ClaveSat,
        string UserName = "ADMINISTRADOR") : Ardalis.SharedKernel.ICommand<Result<int>>;