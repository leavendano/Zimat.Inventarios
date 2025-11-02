using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate.Events;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.CompraAggregate;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class ArticuloUnidad : EntityBase<Guid>, IRegisterBase
{
  private readonly List<Precio> _precios;

  public IEnumerable<Precio> Conceptos
  {
    get { return _precios; }
  }
  public Guid ArticuloId { get; set; }
    public Guid UnidadId { get; set; }
    public string? Unidad { get; set; }
    public decimal FactorConversion { get; set; }
    public string? User { get; set; }
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ArticuloUnidad(Guid articuloId, Guid unidadId, decimal factorConversion)
    {
        ArticuloId = Guard.Against.Null(articuloId, nameof(articuloId));
        UnidadId = Guard.Against.Null(unidadId, nameof(unidadId));
        FactorConversion = Guard.Against.NegativeOrZero(factorConversion, nameof(factorConversion));
        Id = UuidV7.NewGuid();
        User = null;
        Status = RegisterStatus.Activo; // Activo por defecto
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        _precios = [];
     }

    public void AddPrecio(Precio newItem)
    {
      Guard.Against.Null(newItem, nameof(newItem));
      _precios.Add(newItem);
      var newItemAddedEvent = new NewPrecioAddedEvent(this, newItem);
      base.RegisterDomainEvent(newItemAddedEvent);
    }
}
