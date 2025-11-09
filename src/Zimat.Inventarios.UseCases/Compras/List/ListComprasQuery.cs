using Ardalis.Result;
using Ardalis.SharedKernel;


namespace Zimat.Inventarios.UseCases.Compras.List;
public record ListComprasQuery(Guid? ProveedorId, int? TipoDocumentoId, int? Skip, int? Take) : IQuery<Result<IEnumerable<CompraListarDTO>>>;
