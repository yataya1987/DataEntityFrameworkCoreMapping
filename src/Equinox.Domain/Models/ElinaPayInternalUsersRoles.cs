using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Equinox.Domain.Models 
{
	[System.ComponentModel.DataAnnotations.Schema.Table("ElinaPayInternalUsersRoles")]
	public class ElinaPayInternalUsersRoles : Core.Models.Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }

		[System.ComponentModel.DataAnnotations.Schema.ForeignKey("IdKeyUsers")]
		public AgentInternalUsers AgentInternalUsers { get; set; }

		[System.ComponentModel.DataAnnotations.Schema.ForeignKey("IdKeyRoles")]
		public ElinaPayInternalRolesSystem ElinaPayRolesSystem { get; set; }

		public ElinaPayInternalUsersRoles() { }

		public ElinaPayInternalUsersRoles(Guid IdKeyUsers , Guid IdKeyRoles , string description , string notes)
		{

			this.IdKeyUsers = IdKeyUsers;
			this.IdKeyRoles = IdKeyRoles;
			this.description = description;
			this.notes = notes;
		}

		[Column("IdKeyUsers")]
		public Guid? IdKeyUsers { get; set; }

		[Column("IdKeyRoles")]
		public Guid? IdKeyRoles { get; set; }

		[Column("description")]
		private string description { get; set; }

		[Column("notes")]
		private string notes { get; set; }

	}
}
