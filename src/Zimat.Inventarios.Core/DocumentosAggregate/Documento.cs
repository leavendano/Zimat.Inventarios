using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

public class Documento(string folio,DateTime fecha,int clienteId, int proveedorId) : RegisterBase, IAggregateRoot
{
    public string Folio { get; set; } = Guard.Against.NullOrEmpty(folio, nameof(folio));
    public int TipoDocumentoId { get; set; }

    public int? AlmacenId { get; set; }
    public DateTime Fecha { get; set; } = Guard.Against.OutOfSQLDateRange(fecha, nameof(fecha));
    public int ClienteId { get; set; } = Guard.Against.NegativeOrZero(clienteId, nameof(clienteId));
    public int ProveedorId { get; set; } = Guard.Against.NegativeOrZero(proveedorId, nameof(proveedorId));
    public int FormaPagoId { get; set; }
    public int DivisaId { get; set; }
    public DateTime? FechaPago  { get; set; }


}