using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetMvcEvents.Data.Entities
{
	public class Event
	{
		public Event()
		{
			this.IsPublic = true;
			this.StartDateTime = DateTime.Now;
		}

		public int Id { get; set; }

		[Required]
		[MaxLength(200)]
		public string Title { get; set; }

		[Required]
		public DateTime StartDateTime { get; set; }

		[Required]
		public TimeSpan? Duration { get; set; }
		
		[Required]
		public virtual Presenter PresenterId { get; set; }

		[MaxLength(500)]
		public string Description { get; set; }

		[MaxLength(200)]
		public string Location { get; set; }

		public bool IsPublic { get; set; }

		[ForeignKey("PresenterId")]
		public virtual ICollection<Presenter> Presenter { get; set; }
	}
}
