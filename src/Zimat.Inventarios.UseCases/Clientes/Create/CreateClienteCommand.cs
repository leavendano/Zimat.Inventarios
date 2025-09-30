using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Clientes.Create;

public record CreateClienteCommand(string Clave, string Nombre, string Rfc, string CodigoPostal,
    string UserName = "ADMINISTRADOR") : Ardalis.SharedKernel.ICommand<Result<Guid>>;