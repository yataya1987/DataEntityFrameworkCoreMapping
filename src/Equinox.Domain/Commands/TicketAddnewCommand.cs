using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equinox.Domain.Commands
{
	public abstract class TicketAddnewCommand : Core.Commands.Command
	{
		public Guid Id { get; protected set; }

		public string Name { get; protected set; }

		public string Email { get; protected set; }

		public DateTime BirthDate { get; protected set; }
	}
}
