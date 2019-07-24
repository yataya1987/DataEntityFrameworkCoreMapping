using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Equinox.Domain.Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table("AddedTicketsLogger")]
	public class AddedTicketsLogger : Core.Models.Entity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdKey { get; set; }

		public AddedTicketsLogger() { }

		public AddedTicketsLogger( Guid IdKey , DateTime DateTime , string message , string exception , string CLAZZ , string METHOD)
		{

			this.IdKey = IdKey;
			this.DateTime = DateTime;
			this.message = message;
			this.exception = exception;
			this.CLAZZ = CLAZZ;
			this.METHOD = METHOD;

		}

		[System.ComponentModel.DataAnnotations.Schema.ForeignKey("AgentRegisterCasesKey")]
		public AgentRegisterCases AgentRegisterCases { get; set; }

		[Column("AgentRegisterCasesKey")]
		public Guid? AgentRegisterCasesKey { get; set; }

		[Column("AgentRegisteredTicketsKey")]
		public Guid? AgentRegisteredTicketsKey { get; set; }

		[Column("DateTime")]
		private DateTime? DateTime { get; set; }

		[Column("message")]
		private string message { get; set; }

		[Column("exception")]
		private string exception { get; set; }

		[Column("CLAZZ")]
		private string CLAZZ { get; set; }

		[Column("METHOD")]
		private string METHOD { get; set; }
	}
}
