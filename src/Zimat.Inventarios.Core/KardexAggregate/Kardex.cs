using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.Base;

namespace Zimat.Inventarios.Core.KardexAggregate;

public class Kardex : EntityBase<Guid>, IAggregateRoot, IRegisterBase
{
    public Guid ArticuloId { get; private set; }
    public int AlmacenId { get; private set; }
    public int TipoMovimiento { get; private set; }
    public DateTime Fecha { get; private set; }
    public decimal Cantidad { get; private set; }
    public decimal CostoUnitario { get; private set; }
    public decimal CostoTotal { get; private set; }
    public Guid? ReferenciaId { get; set; }
    public string? User { get; set;}

    public int Status { get; set;}
    public DateTime CreatedAt { get; set;}
    public DateTime UpdatedAt { get; set;}

  public Kardex(Guid articuloId, int almacenId, int tipoMovimiento, DateTime fecha, decimal cantidad, decimal costoUnitario) : base()
  {
    ArticuloId = Guard.Against.NullOrEmpty(articuloId, nameof(articuloId));
    AlmacenId = Guard.Against.NegativeOrZero(almacenId, nameof(almacenId));
    Fecha = Guard.Against.OutOfSQLDateRange(fecha, nameof(fecha));
    Cantidad = Guard.Against.Zero(cantidad, nameof(cantidad));
    CostoUnitario = Guard.Against.NegativeOrZero(costoUnitario, nameof(costoUnitario));
    CostoTotal = cantidad * costoUnitario;
    Id = UuidV7.NewGuid();
    CreatedAt = DateTime.UtcNow;
    Status = RegisterStatus.Activo;
  }

  public void UpdateCosto(decimal nuevoCostoUnitario)
  {
    CostoUnitario = Guard.Against.NegativeOrZero(nuevoCostoUnitario, nameof(nuevoCostoUnitario));
    CostoTotal = Cantidad * CostoUnitario;
  }

  public void UpdateCantidad(decimal nuevaCantidad)
  {
    Cantidad = Guard.Against.Zero(nuevaCantidad, nameof(nuevaCantidad));
    CostoTotal = Cantidad * CostoUnitario;
  }
}