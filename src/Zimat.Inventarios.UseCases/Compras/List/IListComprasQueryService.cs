

namespace Zimat.Inventarios.UseCases.Compras.List;
public interface IListComprasQueryService
{
  Task<IEnumerable<CompraDTO>> ListAsync(Guid? ProveedorId, int? TipoDocumentoId);
}
