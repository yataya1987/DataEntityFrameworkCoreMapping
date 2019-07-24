using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Domain.Models
{
	[Table("ElinaPayInternalUsersRoles")]
	public class HistoryTicketsAdded : Core.Models.Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }

		[ForeignKey("AgentRegisterCasesKey")]
		public AgentRegisterCases AgentRegisterCases { get; set; }

		[Column("AgentRegisterCasesKey")]
		public Guid AgentRegisterCasesKey { get; set; }

		[Column("DateTime")]
		public DateTime DateTime { get; set; }

		[Column("Description")]
		public string Description { get; set; }

		[Column("Notes")]
		public string Notes { get; set; }

		public HistoryTicketsAdded(){ }

		public HistoryTicketsAdded(Guid AgentRegisterCasesKey , DateTime DateTime , string Description , string Notes) {
			this.DateTime = DateTime;
			this.Description = Description;
			this.Notes = Notes;
		}

	}
}
