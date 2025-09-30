using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Usuarios.Update;

public record UpdateUsuarioCommand(Guid Id, string Clave, string Nombre, string Email, string Nivel, bool EsVendedor, decimal Comision, int ListaPrecio)
    : Ardalis.SharedKernel.ICommand<Result>;