namespace Zimat.Inventarios.UseCases.Usuarios.List;

public interface IListUsuariosQueryService
{
  Task<IEnumerable<UsuarioDTO>> ListAsync(string? filtro, int? skip, int? take);
}