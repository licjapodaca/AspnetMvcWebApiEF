using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetMvcEvents.Data.Entities
{
	public class Presenter
	{
		public Presenter() { }

		public int Id { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string ProfessionalSkills { get; set; }

		public virtual Event Event { get; set; }
	}
}
