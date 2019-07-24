using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Domain.Models
{
	[Table("AgentGlobalUserAdmin")]
	public class AgentGlobalUserAdmin : Core.Models.Entity
	{   [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }

		public AgentGlobalUserAdmin(string UserName, string Password, bool Activated, bool Blocked, string FirstName, string LastName, string EmploymentNumber, string gender, string description, string notes)
		{
			this.UserName = UserName;
			this.Password = Password;
			this.Activated = Activated;
			this.Blocked = Blocked;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.EmploymentNumber = EmploymentNumber;
			this.Gender = gender;
			this.Description = description;
			this.Notes = notes;
		}
		public AgentGlobalUserAdmin() { }

		[Column("UserName")]
		public string UserName { get; set; }

		[Column("Password")]
		public string Password { get; set; }

		[Column("Activated")]
		public bool Activated { get; set; }

		[Column("Blocked")]
		public bool Blocked { get; set; }

		[Column("FirstName")]
		private string FirstName { get; set; }

		[Column("LastName")]
		public string LastName { get; set; }

		[Column("EmploymentNumber")]
		public string EmploymentNumber { get; set; }

		[Column("Gender")]
		public string Gender { get; set; }

		[Column("Description")]
		public string Description { get; set; }

		[Column("Notes")]
		public string Notes { get; set; }

	}
}
