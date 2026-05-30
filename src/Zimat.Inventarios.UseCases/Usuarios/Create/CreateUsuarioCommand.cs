using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Usuarios.Create;

public record CreateUsuarioCommand(string Clave, string Nombre, string Email, string Nivel, bool EsVendedor, decimal Comision, int ListaPrecio,
    string UserName = "ADMINISTRADOR") : Ardalis.SharedKernel.ICommand<Result<Guid>>;