using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.VentaAggregate;

internal sealed class NewConceptoAddedEvent(Venta documento,VentaConcepto concepto) : DomainEventBase
{
  public Venta DocumentoRoot { get; init; } = documento;
  public VentaConcepto Concepto { get; init; } = concepto;
}