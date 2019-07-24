using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Equinox.Domain.Interfaces
{
	public interface ITicketLogger
	{
		string Name { get; }

		Models.AddedTicketsLogger ElinaPayInternalRolesSystem { get; }

		bool IsAuthenticated();
		IEnumerable<Claim> GetClaimsIdentity();


	}
}
