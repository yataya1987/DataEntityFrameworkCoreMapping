using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Equinox.Domain.Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table("AgentRegisterCases")]
	public class AgentRegisteredTickets : Core.Models.Entity
	{
		[Key]
		public Guid IdKey { get; set; }

		[ForeignKey("AgentInternalUsersKey")]
		public AgentInternalUsers AgentInternalUsers { get; set; }


		public AgentRegisteredTickets() { }

		public AgentRegisteredTickets(Guid IdKey ,
			Guid AgentInternalUsersKey , 
			string AgentName , DateTime AgentLoginTime , 
			int CustomerNumber , bool CRMFound , string CustomerFullName , string CustomerMobile , string CustomerNote , string AgentNote , string FirstName , string SecondName , 
			string ThirdName , string FourthName , string gender , int IDNumber , string PassportNo , string OriginalReason , string OriginalReasonKey , string DetailsBox, Guid modifiedBy , Guid AddedBy ,
			DateTime ModifiedDate , DateTime AddedDate , string ErrorReason , string SuccessString , string ErrorMassage)
		{

			this.IdKey = IdKey;
			this.AgentInternalUsersKey = AgentInternalUsersKey;
			this.AgentName = AgentName;
			this.AgentLoginTime = AgentLoginTime;
			this.CustomerNumber = CustomerNumber;
			this.CRMFound = CRMFound;
			this.CustomerFullName = CustomerFullName;
			this.CustomerMobile = CustomerMobile;
			this.CustomerNote = CustomerNote;
			this.AgentNote = AgentNote;
			this.FirstName = FirstName;
			this.SecondName = SecondName;
			this.ThirdName = ThirdName;
			this.FourthName = FourthName;
			this.gender = gender;
			this.IDNumber = IDNumber;
			this.PassportNo = PassportNo;
			this.OriginalReason = OriginalReason;
			this.OriginalReasonKey = OriginalReasonKey;
			this.DetailsBox = DetailsBox;
			this.modifiedBy = modifiedBy;
			this.AddedBy = AddedBy;
			this.ModifiedDate = ModifiedDate;
			this.AddedDate = AddedDate;
			this.ErrorReason = ErrorReason;
			this.SuccessString = SuccessString;
			this.ErrorMassage = ErrorMassage;

		}
		public Guid AgentInternalUsersKey { get; set; }

		private string AgentName { get; set; }

		private DateTime AgentLoginTime { get; set; }

		private int CustomerNumber { get; set; }

		private bool CRMFound { get; set; }

		private string CustomerFullName { get; set; }

		private string CustomerMobile { get; set; }

		private string CustomerNote { get; set; }

		private string AgentNote { get; set; }

		private string FirstName { get; set; }

		private string SecondName { get; set; }

		private string ThirdName { get; set; }

		private string FourthName { get; set; }

		private string gender{ get; set; }

	    private int IDNumber { get; set; }

		private string PassportNo { get; set; }

		private string OriginalReason { get; set; }

		private string OriginalReasonKey { get; set; }

		private string DetailsBox { get; set; }

		[ForeignKey("modifiedBy")]
		public AgentInternalUsers AgentInternalModifiedBy { get; set; }


		[ForeignKey("AddedBy")]
		public AgentInternalUsers AgentInternalAddedBy { get; set; }

		private Guid modifiedBy { get; set; }

		private Guid AddedBy { get; set; }

		private DateTime ModifiedDate { get; set; }

		private DateTime AddedDate { get; set; }

		private string ErrorReason { get; set; }

		private string SuccessString { get; set; }

		private string ErrorMassage { get; set; }



	}
}
