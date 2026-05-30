using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Zimat.Inventarios.UseCases.Usuarios.List;

public record ListUsuariosQuery(string? filtro, int? Skip, int? Take) : IQuery<Result<IEnumerable<UsuarioDTO>>>;