using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.DocumentoAggregate.Events;

/// <summary>
/// A domain event that is dispatched whenever a contributor is deleted.
/// The DeleteContributorService is used to dispatch this event.
/// </summary>
internal sealed class NewConceptoAddedEvent(Documento documento,DocumentoConcepto concepto) : DomainEventBase
{
  public Documento DocumentoRoot { get; init; } = documento;
  public DocumentoConcepto Concepto { get; init; } = concepto;
}
