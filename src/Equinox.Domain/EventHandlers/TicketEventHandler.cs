using System.Threading;
using System.Threading.Tasks;
using Equinox.Domain.Events;
using MediatR;

namespace Equinox.Domain.EventHandlers
{
	public class TicketEventHandler : INotificationHandler<TicketAddEvent>, INotificationHandler<TicketUpdateEvent>, INotificationHandler<TicketRemoveEvent>
	{
		public Task Handle(TicketAddEvent message, CancellationToken cancellationToken)
		{
			// Send some notification e-mail

			return Task.CompletedTask;
		}

		public Task Handle(TicketUpdateEvent message, CancellationToken cancellationToken)
		{
			// Send some greetings e-mail

			return Task.CompletedTask;
		}

		public Task Handle(TicketRemoveEvent message, CancellationToken cancellationToken)
		{
			// Send some see you soon e-mail

			return Task.CompletedTask;
		}
	}
}