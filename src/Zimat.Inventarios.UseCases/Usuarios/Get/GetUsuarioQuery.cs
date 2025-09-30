using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Usuarios.Get;

public record GetUsuarioQuery(Guid UsuarioId) : IQuery<Result<UsuarioDTO>>;