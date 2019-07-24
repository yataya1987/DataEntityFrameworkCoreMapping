using System;
using System.Threading;
using System.Threading.Tasks;
using Equinox.Domain.Commands;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Events;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using MediatR;

namespace Equinox.Domain.CommandHandlers
{
	public class TicketCommandHandler : CommandHandler,IRequestHandler<TicketAddnewCommand, bool>,IRequestHandler<TicketRemoveCommand, bool>,IRequestHandler<TicketUpdateCommand, bool>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMediatorHandler Bus;

		public TicketCommandHandler(ICustomerRepository customerRepository,IUnitOfWork uow,IMediatorHandler bus,INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
		{
			_customerRepository = customerRepository;
			Bus = bus;
		}

		public Task<bool> Handle(TicketAddnewCommand message, CancellationToken cancellationToken)
		{
			if (!message.IsValid())
			{
				NotifyValidationErrors(message);
				return Task.FromResult(false);
			}

			var customer = new Customer(Guid.NewGuid(), message.Name, message.Email, message.BirthDate);

			if (_customerRepository.GetByEmail(customer.Email) != null)
			{
				Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
				return Task.FromResult(false);
			}

			_customerRepository.Add(customer);

			if (Commit())
			{
				Bus.RaiseEvent(new CustomerRegisteredEvent(customer.Id, customer.Name, customer.Email, customer.BirthDate));
			}

			return Task.FromResult(true);
		}

		public Task<bool> Handle(TicketUpdateCommand message, CancellationToken cancellationToken)
		{
			if (!message.IsValid())
			{
				NotifyValidationErrors(message);
				return Task.FromResult(false);
			}

			var customer = new Customer(message.Id, message.Name, message.Email, message.BirthDate);
			var existingCustomer = _customerRepository.GetByEmail(customer.Email);

			if (existingCustomer != null && existingCustomer.Id != customer.Id)
			{
				if (!existingCustomer.Equals(customer))
				{
					Bus.RaiseEvent(new DomainNotification(message.MessageType, "The customer e-mail has already been taken."));
					return Task.FromResult(false);
				}
			}

			_customerRepository.Update(customer);

			if (Commit())
			{
				Bus.RaiseEvent(new CustomerUpdatedEvent(customer.Id, customer.Name, customer.Email, customer.BirthDate));
			}

			return Task.FromResult(true);
		}

		public Task<bool> Handle(TicketRemoveCommand message, CancellationToken cancellationToken)
		{
			if (!message.IsValid())
			{
				NotifyValidationErrors(message);
				return Task.FromResult(false);
			}

			_customerRepository.Remove(message.Id);

			if (Commit())
			{
				Bus.RaiseEvent(new CustomerRemovedEvent(message.Id));
			}

			return Task.FromResult(true);
		}

		public void Dispose()
		{
			_customerRepository.Dispose();
		}

		
	}
}