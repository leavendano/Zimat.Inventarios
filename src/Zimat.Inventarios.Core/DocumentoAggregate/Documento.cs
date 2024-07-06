using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.DocumentoAggregate;

public class Documento(string folio,DateTime fecha,int? clienteId, int? proveedorId,decimal importe) : RegisterBase, IAggregateRoot
{
    public string Folio { get; set; } = Guard.Against.NullOrEmpty(folio, nameof(folio));
    public int TipoDocumentoId { get; set; }

    public int? AlmacenId { get; set; } 
    public DateTime Fecha { get; set; } = Guard.Against.OutOfSQLDateRange(fecha, nameof(fecha));
    public int? ClienteId { get; set; } = clienteId;
    public int? ProveedorId { get; set; } = proveedorId;
    public int? FormaPagoId { get; set; }
    public string Divisa { get; set; } = "MXN";
    public decimal TipoCambio { get; set; } = 1m;
    public decimal PDescuento { get; set; } = 0m;
    public decimal Descuento { get; set; } = 0m;
    public DateTime? FechaPago  { get; set; }
    public string? Referencia { get; set; }
    public decimal Importe {  get; set; } = Guard.Against.NegativeOrZero(importe, nameof(importe));


}
