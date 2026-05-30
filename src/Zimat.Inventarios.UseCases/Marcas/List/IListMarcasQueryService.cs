namespace Zimat.Inventarios.UseCases.Marcas.List;

public interface IListMarcasQueryService
{
    Task<IEnumerable<MarcaDTO>> ListAsync(int? skip, int? take);
}
