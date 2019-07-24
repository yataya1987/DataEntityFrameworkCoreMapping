﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equinox.Domain.Events
{
	public class TicketUpdateEvent : Core.Events.Event
	{

		public string TicketName { get; set; }

		public string TicketNumber { get; set; }

		public string CustomerName { get; set; }

		public string CustomerId { get; set; }

		public string Passport { get; set; }

		public TicketUpdateEvent() { }

		public TicketUpdateEvent(string TicketName , string TicketNumber , string CustomerName, string CustomerId , string Passport) {
			this.TicketName = TicketName;
			this.CustomerName = CustomerName;
			this.CustomerId = CustomerId;
			this.Passport = Passport;
		}

	}
}
