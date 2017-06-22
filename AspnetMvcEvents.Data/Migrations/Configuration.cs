namespace AspnetMvcEvents.Data.Migrations
{
	using AspnetMvcEvents.Data.Entities;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	//internal sealed
	public class Configuration : DbMigrationsConfiguration<AspnetMvcEvents.Data.Context.EventsContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(AspnetMvcEvents.Data.Context.EventsContext context)
		{
			context.Presenters.AddOrUpdate(p => p.Name,
				new Presenter
				{
					Name = "Jorge Mario",
					Lastname = "Apodaca Mendoza",
					ProfessionalSkills = "Skills in TFS, Sencha ExtJS, C#, Oracle, SQL Server, CI/CD, DevOps, SCRUM, AWS, Azure",
					Events = new List<Event>()
					{
						new Event { Title = "Curso de ASP.NET MVC", Description = "Curso de ASP.NET MVC", Duration = TimeSpan.Parse("4:00"), IsPublic = true, Location = "Mexicali, B.C." },
						new Event { Title = "Team Foundation Server", Description = "Curso de Team Foundation Server", Duration = TimeSpan.Parse("6:00"), IsPublic = true, Location = "Guadalajara, Jalisco" }
					}
				},
				new Presenter
				{
					Name = "Ricardo",
					Lastname = "Lopez Medina",
					ProfessionalSkills = "Office 365, TFS",
					Events = new List<Event>()
					{
						new Event { Title = "Curso de Office 365", Description = "Curso de Office 365", Duration = TimeSpan.Parse("2:00"), IsPublic = false, Location = "Mexicali, B.C." },
						new Event { Title = "Curso de Nominas", Description = "Curso de Nominas", Duration = TimeSpan.Parse("1:30"), IsPublic = true, Location = "C.D. de Mexico" }
					}
				});
		}
	}
}
