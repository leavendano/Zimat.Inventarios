using System.Data.Common;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.DocumentoAggregate.Events;

namespace Zimat.Inventarios.Core.DocumentoAggregate;

public class Documento : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
    private List<DocumentoConcepto> _conceptos;

    public IEnumerable<DocumentoConcepto> Conceptos
    {
            get { return _conceptos.AsReadOnly(); }
    }
    public string Folio { get; set; } 
    public int TipoDocumentoId { get; set; }

    public int? AlmacenId { get; set; } 
    public DateTime Fecha { get; set; } 
    public int? ClienteId { get; set; }
    public int? ProveedorId { get; set; }
    public int? FormaPagoId { get; set; }
    public string Divisa { get; set; } = "MXN";
    public decimal TipoCambio { get; set; } = 1m;
    public decimal PDescuento { get; set; } = 0m;
    public decimal Descuento { get; set; } = 0m;
    public DateTime? FechaPago  { get; set; }
    public string? Referencia { get; set; }
    public decimal Importe {  get; set; } 


    public string? Usuario { get; set;}	
  	public int Estatus { get; set;} = 1;
  	public DateTime CreatedAt { get; set;}
  	public DateTime UpdatedAt { get; set;}

    public Documento(string folio,DateTime fecha,int? clienteId, int? proveedorId,decimal importe) : base()
    {
        Folio = Guard.Against.NullOrEmpty(folio, nameof(folio));
        Fecha = Guard.Against.OutOfSQLDateRange(fecha, nameof(fecha));
        ClienteId = clienteId;
        ProveedorId = proveedorId;
        Importe = Guard.Against.NegativeOrZero(importe, nameof(importe));
        Id = new UuidV7().Value;
        _conceptos = new List<DocumentoConcepto>();
    }

    public void AddConcepto(DocumentoConcepto newItem)
  {
    Guard.Against.Null(newItem, nameof(newItem));
    _conceptos.Add(newItem);
    Importe += newItem.Importe;

    var newItemAddedEvent = new NewConceptoAddedEvent(this, newItem);
    base.RegisterDomainEvent(newItemAddedEvent);
  }
}
