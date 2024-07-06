using Ardalis.Result;
using Ardalis.SharedKernel;
using MediatR;
using Microsoft.Extensions.Logging;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.ArticuloAggregate.Events;
using Zimat.Inventarios.Core.Interfaces;

namespace Zimat.Inventarios.Core.Services;
public class DeleteArticuloService(IRepository<Articulo> _repository,
  IMediator _mediator,
  ILogger<DeleteContributorService> _logger) : IDeleteArticuloService
{
  public async Task<Result> DeleteArticulo(int articuloId)
  {
    _logger.LogInformation("Eliminando Articulo {contributorId}", articuloId);
    Articulo? aggregateToDelete = await _repository.GetByIdAsync(articuloId);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new ArticuloDeletedEvent(articuloId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}
