

namespace Zimat.Inventarios.UseCases.Ventas.List;
public interface IListVentasQueryService
{
  Task<IEnumerable<VentaDTO>> ListAsync(Guid? ClienteId, int? TipoDocumentoId);
}
