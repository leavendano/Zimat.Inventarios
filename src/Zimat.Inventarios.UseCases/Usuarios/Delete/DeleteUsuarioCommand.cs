using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Usuarios.Delete;

public record DeleteUsuarioCommand(Guid UsuarioId) : ICommand<Result>;