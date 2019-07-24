using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
namespace Equinox.Domain.Interfaces
{
	public interface IElinaPayInternalUR
	{
		string Name { get; }

		Models.ElinaPayInternalUsersRoles AgentInternalUsers { get; }

		bool IsAuthenticated();
		IEnumerable<Claim> GetClaimsIdentity();
	}
}
