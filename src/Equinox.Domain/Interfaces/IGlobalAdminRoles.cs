using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Equinox.Domain.Interfaces
{
	public interface IGlobalAdminRoles
	{

		string Name { get; }

		Models.AgentGlobalAdminRolesSystem AgentGlobalAdminRolesSystem { get; }

		bool IsAuthenticated();
		IEnumerable<Claim> GetClaimsIdentity();
	}
}
