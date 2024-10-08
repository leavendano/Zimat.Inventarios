﻿using Ardalis.SharedKernel;

namespace Zimat.Inventarios.Core.ArticuloAggregate.Events;

/// <summary>
/// A domain event that is dispatched whenever a contributor is deleted.
/// The DeleteContributorService is used to dispatch this event.
/// </summary>
internal sealed class ArticuloDeletedEvent(Guid articuloId) : DomainEventBase
{
  public Guid ArticuloId { get; init; } = articuloId;
}
