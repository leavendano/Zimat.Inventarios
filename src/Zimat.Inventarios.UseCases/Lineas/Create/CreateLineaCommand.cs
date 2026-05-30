using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Lineas.Create;

  public record CreateLineaCommand(string Descripcion, decimal Margen,
        string UserName = "ADMINISTRADOR") : Ardalis.SharedKernel.ICommand<Result<Guid>>;