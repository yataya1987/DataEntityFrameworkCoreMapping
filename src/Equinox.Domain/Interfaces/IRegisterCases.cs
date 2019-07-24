using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Equinox.Domain.Interfaces
{
	public interface IRegisterCases
	{
		string Name { get; }

		Models.AgentRegisterCases AgentGlobalAdminUsersRoles { get; }

		bool IsAuthenticated();
		IEnumerable<Claim> GetClaimsIdentity();

	}
}
