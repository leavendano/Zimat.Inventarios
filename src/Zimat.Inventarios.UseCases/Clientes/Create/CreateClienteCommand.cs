using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Clientes.Create;

public record CreateClienteCommand(ClienteCrearDTO Cliente, string UserName = "ADMINISTRADOR")
    : Ardalis.SharedKernel.ICommand<Result<Guid>>;