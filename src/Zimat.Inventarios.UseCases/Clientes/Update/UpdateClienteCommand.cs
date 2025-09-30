using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Clientes.Update;

public record UpdateClienteCommand(Guid Id, string Clave, string Nombre, string Rfc, string CodigoPostal)
    : Ardalis.SharedKernel.ICommand<Result>;