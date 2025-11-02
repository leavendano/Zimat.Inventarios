using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Familias.Create;

  public record CreateFamiliaCommand(string Descripcion, decimal Margen,
        string UserName = "ADMINISTRADOR") : Ardalis.SharedKernel.ICommand<Result<Guid>>;
