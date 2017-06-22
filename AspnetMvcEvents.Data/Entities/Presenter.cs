using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetMvcEvents.Data.Entities
{
	public class Presenter
	{
		public Presenter() { }

		public int Id { get; set; }
		[Required]
		[MaxLength(20)]
		public string Name { get; set; }
		[Required]
		[MaxLength(30)]
		public string Lastname { get; set; }
		[Required]
		[MaxLength(500)]
		public string ProfessionalSkills { get; set; }

		public virtual ICollection<Event> Events { get; set; }
	}
}