using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.VentaAggregate;

public class Venta : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
private List<VentaConcepto> _conceptos;

    public IEnumerable<VentaConcepto> Conceptos
    {
            get { return _conceptos.AsReadOnly(); }
    }
    public string Folio { get; set; } 
    public int TipoDocumentoId { get; set; }

    public int? AlmacenId { get; set; } 
    public DateTime Fecha { get; set; } 
    public Guid? ClienteId { get; set; }
    public int? FormaPagoId { get; set; }
    public string Divisa { get; set; } = "MXN";
    public decimal TipoCambio { get; set; } = 1m;
    public decimal PDescuento { get; set; } = 0m;
    public decimal Descuento { get; set; } = 0m;
    public DateTime? FechaPago  { get; set; }
    public string? Referencia { get; set; }
    public decimal Importe {  get; set; } 
    public decimal Impuesto1 { get; set; } = 0;
    public decimal Impuesto2 { get; set; } = 0;
    public bool Pagado { get; set; } = false;
    public decimal SaldoAnticipo { get; set; } = 0;
    public string? User { get; set;}	
  	public int Status { get; set;}
  	public DateTime CreatedAt { get; set;}
  	public DateTime UpdatedAt { get; set;}

  public Venta(string folio, DateTime fecha, Guid? clienteId, decimal importe) : base()
  {
    Folio = Guard.Against.NullOrEmpty(folio, nameof(folio));
    Fecha = Guard.Against.OutOfSQLDateRange(fecha, nameof(fecha));
    ClienteId = clienteId;
    Importe = Guard.Against.NegativeOrZero(importe, nameof(importe));
    Id = UuidV7.NewGuid();
    _conceptos = [];
    CreatedAt = DateTime.UtcNow;
    Status = RegisterStatus.Activo; // Activo por defecto
    }

    public void AddConcepto(VentaConcepto newItem)
  {
    Guard.Against.Null(newItem, nameof(newItem));
    _conceptos.Add(newItem);
    Importe += newItem.Importe;
    Impuesto1 += newItem.Impuesto1;
    Impuesto2 += newItem.Impuesto2;

    var newItemAddedEvent = new NewConceptoAddedEvent(this, newItem);
    base.RegisterDomainEvent(newItemAddedEvent);
  }

}