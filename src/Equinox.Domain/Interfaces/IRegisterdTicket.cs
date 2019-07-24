﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;


namespace Equinox.Domain.Interfaces
{
	public interface IRegisterdTicket
	{
		string Name { get; }

		Models.AgentRegisteredTickets AgentRegisteredTickets { get; }

		bool IsAuthenticated();
		IEnumerable<Claim> GetClaimsIdentity();

	}
}
