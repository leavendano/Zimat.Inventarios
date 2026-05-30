using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.VentaAggregate;

public class VentaConcepto : EntityBase<Guid>
{
   public Guid VentaId { get; set; } 
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

  public VentaConcepto(Guid ventaId, Guid articuloId, decimal precio, decimal costo, decimal cantidad, decimal impuesto1)
  {
    VentaId = Guard.Against.Null(ventaId, nameof(ventaId));
    ArticuloId = Guard.Against.Null(articuloId, nameof(articuloId));
    Precio = Guard.Against.NegativeOrZero(precio, nameof(precio));
    Costo = Guard.Against.Negative(costo, nameof(costo));
    CostoPromedio = 0;
    Cantidad = Guard.Against.NegativeOrZero(cantidad, nameof(cantidad));
    Pendiente = Guard.Against.NegativeOrZero(cantidad, nameof(cantidad));
    Devueltos = 0;
    Descuento = 0;
    Impuesto1 = Guard.Against.Negative(impuesto1, nameof(impuesto1));
    Impuesto2 = 0;
    Importe = 0;
    base.Id = UuidV7.NewGuid();
    Status = RegisterStatus.Activo;; // Activo por defecto
    CreatedAt = DateTime.UtcNow;
    UpdatedAt = DateTime.UtcNow;
  }

  public string? User { get; set;}	
  public int Status { get; set;}
  public DateTime CreatedAt { get; set;}
  public DateTime UpdatedAt { get; set;}
}