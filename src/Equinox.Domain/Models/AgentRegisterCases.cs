using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Equinox.Domain.Models
{
	[Table("AgentRegisterCases")]
	public class AgentRegisterCases : Core.Models.Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }

		public AgentRegisterCases() { }

		public AgentRegisterCases(Guid IdKey , Guid AgentRegisteredTicketsKey , string CaseName , DateTime DateTime , string description , string notes)
		{
			this.IdKey = IdKey;
			this.AgentRegisteredTicketsKey = AgentRegisteredTicketsKey;
			this.DateTime = DateTime;
			this.description = description;
			this.notes = notes;
		}

		[ForeignKey("AgentRegisteredTicketsKey")]
		public AgentRegisteredTickets AgentRegisteredTickets { get; set; }

		[Column("AgentRegisteredTicketsKey")]
		public Guid AgentRegisteredTicketsKey { get; set; }

		[Column("CaseName")]
		public string CaseName { get; set; }

		[Column("DateTime")]
		public DateTime DateTime { get; set; }

		[Column("description")]
		public string description { get; set; }

		[Column("notes")]
		public string notes { get; set; }


	}
}
