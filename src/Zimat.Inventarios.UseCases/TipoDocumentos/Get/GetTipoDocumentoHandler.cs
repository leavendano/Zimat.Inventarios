using Ardalis.Result;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.TipoDocumentoAggregate;
using Zimat.Inventarios.Core.TipoDocumentoAggregate.Specifications;
using Zimat.Inventarios.UseCases.TipoDocumentos;

namespace Zimat.Inventarios.UseCases.TipoDocumentos.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetTipoDocumentoHandler(IReadRepository<TipoDocumento> _repository)
  : IQueryHandler<GetTipoDocumentoQuery, Result<TipoDocumentoDTO>>
{
  public async Task<Result<TipoDocumentoDTO>> Handle(GetTipoDocumentoQuery request, CancellationToken cancellationToken)
  {
    var spec = new TipoDocumentoByIdSpec(request.TipoDocumentoId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new TipoDocumentoDTO(
        entity.Id,
        entity.Nombre,
        entity.EsEntrada,
        entity.EsSalida,
        entity.AfectaInventario,
        entity.AfectaCuentasPorPagar,
        entity.AfectaCuentasPorCobrar,
        entity.RequiereProveedor,
        entity.RequiereCliente,
        entity.Prefijo,
        entity.UltimoFolio
    );
  }
}
