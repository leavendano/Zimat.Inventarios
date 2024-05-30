using MediatR;
using Microsoft.Extensions.Logging;
using Zimat.Inventarios.Core.ArticuloAggregate.Events;
using Zimat.Inventarios.Core.Interfaces;

namespace Zimat.Inventarios.Core.ArticulosAgrregate.Handlers;
internal class ArticuloDeletedHandler(ILogger<ArticuloDeletedHandler> logger,
  IEmailSender emailSender) : INotificationHandler<ArticuloDeletedEvent>
{
  public async Task Handle(ArticuloDeletedEvent domainEvent, CancellationToken cancellationToken)
  {
    logger.LogInformation("Handling Contributed Deleted event for {contributorId}", domainEvent.ArticuloId);

    await emailSender.SendEmailAsync("leavendano@gmail.com",
                                     "cfdi@infinitummail.com",
                                     "Contributor Deleted",
                                     $"El Articulo con el id {domainEvent.ArticuloId} fue borrado.");
  }
}

