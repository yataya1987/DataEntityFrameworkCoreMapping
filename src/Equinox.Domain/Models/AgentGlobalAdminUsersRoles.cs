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
	public class AgentGlobalAdminUsersRoles : Core.Models.Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }

		[ForeignKey("IdKeyUsers")]
		public AgentGlobalUserAdmin AgentGlobalUserAdmin { get; set; }

		[ForeignKey("IdKeyRoles")]
		public AgentGlobalAdminRolesSystem ElinaPayRolesSystem { get; set; }

		public AgentGlobalAdminUsersRoles() { }


		public AgentGlobalAdminUsersRoles(Guid IdKeyUsers , Guid IdKeyRoles , string description , string notes)
		{
			this.IdKeyUsers = IdKeyUsers;
			this.IdKeyRoles = IdKeyRoles;
			this.Description = description;
			this.Notes = notes;
		}
		
		[Column("IdKeyUsers")]
		public Guid IdKeyUsers { get; set; }

		[Column("IdKeyRoles")]
		public Guid IdKeyRoles { get; set; }

		[Column("Description")]
		private string Description { get; set; }

		[Column("Notes")]
		private string Notes { get; set; }

	}
}
