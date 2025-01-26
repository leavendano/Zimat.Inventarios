using System.Data.Common;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.DocumentoAggregate;
public class DocumentoConcepto : EntityBase<Guid>, IRegisterBase
{
  public Guid DocumentoId { get; set; } 
  public Guid ArticuloId { get; set; }
  public decimal Precio { get; set; } 
  public decimal Costo { get; set; }
  public decimal CostoPromedio { get; set; }
  public decimal Cantidad { get; set; } 
  public decimal Pendiente { get; set; }
  public decimal Devueltos { get; set; }
  public decimal Descuento { get; set; } 
  public decimal Impuesto1 { get; set; }
  public decimal Impuesto2 { get; set; } 
  public string? NumeroSerie { get; set; }
  public decimal Importe { get; set; } = 0;

  public DocumentoConcepto(Guid documentoId,Guid articuloId,decimal precio,decimal costo,decimal cantidad,decimal impuesto1)
  {
    DocumentoId  = Guard.Against.Null(documentoId,nameof(documentoId));
    ArticuloId = Guard.Against.Null(articuloId,nameof(articuloId));
    Precio  = Guard.Against.NegativeOrZero(precio,nameof(precio));
    Costo  = Guard.Against.Negative(costo,nameof(costo));
    CostoPromedio  = 0;
    Cantidad  = Guard.Against.NegativeOrZero(cantidad,nameof(cantidad));
    Pendiente  = Guard.Against.NegativeOrZero(cantidad, nameof(cantidad));
    Devueltos  = 0;
    Descuento  = 0;
    Impuesto1  = Guard.Against.Negative(impuesto1, nameof(impuesto1));
    Impuesto2  = 0; 
    Importe  = 0;
    base.Id = new UuidV7().Value;
  }

  public string? Usuario { get; set;}	
  public int Estatus { get; set;} = 1;
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}

}
