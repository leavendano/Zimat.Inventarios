using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Zimat.Inventarios.Core.ArticuloAggregate.Events;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.CompraAggregate;
using Zimat.Inventarios.Core.UnidadAggregate;

namespace Zimat.Inventarios.Core.ArticuloAggregate;

public class ArticuloUnidad : EntityBase<Guid>, IRegisterBase
{
  private readonly List<Precio> _precios;

  public IReadOnlyCollection<Precio> Precios => _precios.AsReadOnly();
 
    public Guid ArticuloId { get; set; }
    public Guid UnidadId { get; set; }
    
    public virtual Unidad Unidad { get; private set; } = null!;
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
      var existente = _precios.FirstOrDefault(x => x.NumeroLista == newItem.NumeroLista);
      if (existente != null)
      {
        existente.ImportePrecio = newItem.ImportePrecio;
        existente.FactorCosto = newItem.FactorCosto;
        existente.UpdatedAt = DateTime.UtcNow;
        var precioUpdatedEvent = new PrecioUpdatedEvent(this, existente);
        base.RegisterDomainEvent(precioUpdatedEvent);
        return;
      }
      else
      {
        _precios.Add(newItem);
        var newItemAddedEvent = new NewPrecioAddedEvent(this, newItem);
        base.RegisterDomainEvent(newItemAddedEvent);
      }
    }

    public void RemovePrecio(Guid precioId)
    {
      var precio = _precios.FirstOrDefault(x => x.Id == precioId);
      if (precio == null)
      {
        throw new InvalidOperationException($"No se encontró Precio con Id {precioId}");
      }

      _precios.Remove(precio);
    }
}
