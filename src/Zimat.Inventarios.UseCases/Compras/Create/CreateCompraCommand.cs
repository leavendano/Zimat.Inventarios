using Ardalis.Result;

namespace Zimat.Inventarios.UseCases.Compras.Create;
public record CreateCompraCommand(string Folio, DateTime Fecha, int TipoDocumentoId, Guid? ProveedorId,
        decimal Importe, Guid? DocumentoRelacionadoId, IEnumerable<CompraConceptoDTO>? conceptos) : Ardalis.SharedKernel.ICommand<Result<Guid>>;
