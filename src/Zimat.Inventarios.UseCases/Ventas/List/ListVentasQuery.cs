using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Ventas.List;
public record ListVentasQuery(Guid? ClienteId, int? TipoDocumentoId, int? Skip, int? Take) : IQuery<Result<IEnumerable<VentaDTO>>>;
