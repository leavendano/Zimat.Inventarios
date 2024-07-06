using Ardalis.GuardClauses;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.DocumentoAggregate;
public class DocumentoConcepto(int documentoId,int articuloId,decimal precio,decimal costo,decimal cantidad,decimal impuesto1) : RegisterBase
{
  public int DocumentoId { get; set; } = Guard.Against.NegativeOrZero(documentoId,nameof(documentoId));
  public int ArticuloId { get; set; } = Guard.Against.NegativeOrZero(articuloId,nameof(articuloId));
  public decimal Precio { get; set; } = Guard.Against.NegativeOrZero(precio,nameof(precio));
  public decimal Costo { get; set; } = Guard.Against.Negative(costo,nameof(costo));
  public decimal CostoPromedio { get; set; } = 0;
  public decimal Cantidad { get; set; } = Guard.Against.NegativeOrZero(cantidad,nameof(cantidad));
  public decimal Pendiente { get; set; } = Guard.Against.NegativeOrZero(cantidad, nameof(cantidad));
  public decimal Devueltos { get; set; } = 0;
  public decimal PDescuento { get; set; } = 0;
  public decimal Impuesto1 { get; set; } = Guard.Against.Negative(impuesto1, nameof(impuesto1));
  public decimal Impuesto2 { get; set; } = 0; 
  public string? NumeroSerie { get; set; }

}
