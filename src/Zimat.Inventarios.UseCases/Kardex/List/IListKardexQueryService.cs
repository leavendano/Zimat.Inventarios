namespace Zimat.Inventarios.UseCases.Kardex.List;

public interface IListKardexQueryService
{
    Task<IEnumerable<KardexListarDTO>> ListAsync(Guid? articuloId, int? almacenId, int? skip, int? take);
}
