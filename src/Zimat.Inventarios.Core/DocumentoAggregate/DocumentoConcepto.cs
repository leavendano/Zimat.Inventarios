using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.DocumentoAggregate;
public class DocumentoConcepto(Guid documentoId,int articuloId,decimal precio,decimal costo,decimal cantidad,decimal impuesto1) : EntityBase<Guid>, IRegisterBase
{
  public Guid DocumentoId { get; set; } = Guard.Against.Null(documentoId,nameof(documentoId));
  public int ArticuloId { get; set; } = Guard.Against.NegativeOrZero(articuloId,nameof(articuloId));
  public decimal Precio { get; set; } = Guard.Against.NegativeOrZero(precio,nameof(precio));
  public decimal Costo { get; set; } = Guard.Against.Negative(costo,nameof(costo));
  public decimal CostoPromedio { get; set; } = 0;
  public decimal Cantidad { get; set; } = Guard.Against.NegativeOrZero(cantidad,nameof(cantidad));
  public decimal Pendiente { get; set; } = Guard.Against.NegativeOrZero(cantidad, nameof(cantidad));
  public decimal Devueltos { get; set; } = 0;
  public decimal Descuento { get; set; } = 0;
  public decimal Impuesto1 { get; set; } = Guard.Against.Negative(impuesto1, nameof(impuesto1));
  public decimal Impuesto2 { get; set; } = 0; 
  public string? NumeroSerie { get; set; }
  public decimal Importe { get; set; } = 0;

  public string? Usuario { get; set;}	
  public int Estatus { get; set;} = 1;
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}

}
