namespace Zimat.Inventarios.UseCases.Unidades.List;
public interface IListUnidadesQueryService
{
  Task<IEnumerable<UnidadDTO>> ListAsync(Guid? articuloId,int? skip, int? take);
}
