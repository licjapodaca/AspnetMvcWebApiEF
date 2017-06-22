using AspnetMvcEvents.Data.Entities;
using AspnetMvcEvents.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetMvcEvents.Data.Context
{
    public class EventsContext : DbContext
    {
        public EventsContext()
            : base("AspnetMvcEvents") { }

		#region Entidades por IDbSet

		public IDbSet<Event> Events { get; set; }
		public IDbSet<Presenter> Presenters { get; set; }

		#endregion
	}
}
