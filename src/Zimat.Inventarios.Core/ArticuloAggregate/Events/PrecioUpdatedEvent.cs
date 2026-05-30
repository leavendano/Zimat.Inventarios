using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.ArticuloAggregate.Events;
internal sealed class PrecioUpdatedEvent(ArticuloUnidad unidad, Precio precio) : DomainEventBase
{
  public ArticuloUnidad UnidadRoot { get; init; } = unidad;
  public Precio Precio { get; init; } = precio;
 
}