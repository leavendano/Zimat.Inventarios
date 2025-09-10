namespace Zimat.Inventarios.UseCases.Articulos.List;

public interface IListArticulosQueryService
{
  Task<IEnumerable<ArticuloListarDTO>> ListAsync(string? filtro, int? skip, int? take);
  Task<IEnumerable<ArticuloPrecioListarDTO>> ListPreciosAsync(string? filtro, int? skip, int? take);
}
