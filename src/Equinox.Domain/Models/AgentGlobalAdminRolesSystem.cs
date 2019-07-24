using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Equinox.Domain.Models
{
	[Table("AgentGlobalAdminRolesSystem")]
	public class AgentGlobalAdminRolesSystem : Core.Models.Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }
		public AgentGlobalAdminRolesSystem(string RoleName, bool READ, bool WRITE, bool UPDATE)
		{
			this.RoleName = RoleName;
			this.READ = READ;
			this.WRITE = WRITE;
			this.UPDATE = UPDATE;

		}

		public List<ElinaPayInternalUsersRoles> ElinaPayUsersRoles { get; set; }

		public AgentGlobalAdminRolesSystem() { }

		[Column("RoleName")]
		public string RoleName { get; set; }

		[Column("READ")]
		public bool READ { get; set; }

		[Column("WRITE")]
		public bool WRITE { get; set; }

		[Column("UPDATE")]
		public bool UPDATE { get; set; }
	}
}
