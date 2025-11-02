using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.CompraAggregate.Events;

/// <summary>
/// A domain event that is dispatched whenever a concepto is added to a compra.
/// </summary>
internal sealed class NewConceptoAddedEvent(Compra compra, CompraConcepto concepto) : DomainEventBase
{
  public Compra CompraRoot { get; init; } = compra;
  public CompraConcepto Concepto { get; init; } = concepto;
}
