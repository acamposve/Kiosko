using Kiosko.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kiosko.Application.CompanyActivities.EventHandlers
{
    public class CompanyActivityCreatedEventHandler : INotificationHandler<CompanyActivityCreatedEvent>
    {
        private readonly ILogger<CompanyActivityCreatedEventHandler> _logger;

        public CompanyActivityCreatedEventHandler(ILogger<CompanyActivityCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(CompanyActivityCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("CleanArchitecture Domain Event: {DomainEvent}", notification.GetType().Name);

            return Task.CompletedTask;
        }
    }
}
