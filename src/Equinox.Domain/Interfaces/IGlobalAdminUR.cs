using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
namespace Equinox.Domain.Interfaces
{
	interface IGlobalAdminUR
	{
		string Name { get; }

		Models.AgentGlobalAdminUsersRoles AgentGlobalAdminUsersRoles { get; }

		bool IsAuthenticated();
		IEnumerable<Claim> GetClaimsIdentity();
	}
}
