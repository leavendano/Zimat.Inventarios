namespace Zimat.Inventarios.UseCases.Clientes;
public interface IListClientesQueryService
{
  Task<IEnumerable<ClienteDTO>> ListAsync(string? filtro, int? Skip, int? Take);
}