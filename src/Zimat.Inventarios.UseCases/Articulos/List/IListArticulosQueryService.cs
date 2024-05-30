namespace Zimat.Inventarios.UseCases.Articulos.List;
public interface IListArticulosQueryService
{
  Task<IEnumerable<ArticuloDTO>> ListAsync();
}
