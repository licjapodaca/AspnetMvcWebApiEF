using AspnetMvcEvents.Data;
using AspnetMvcEvents.Data.Entities;
using AspnetMvcEvents.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspnetMvcEvents.Services.Controllers
{
	[Authorize]
    public class EventsController : ApiController
    {
		ApplicationDbContext ctx = new ApplicationDbContext();

		public IHttpActionResult GetAll()
		{
			var result = new List<Event>();
			var capaBLL = new Negocio();

			try
			{
				capaBLL.VerificarIdentidad();
				ctx.Configuration.LazyLoadingEnabled = false;
				result = ctx.Events.ToList();
			}
			catch (Exception ex)
			{
				InternalServerError(ex);
			}

			return Ok(result);
		}

		[AllowAnonymous]
		public IHttpActionResult Get(int id)
		{
			Event resultado = new Event();

			try
			{
				ctx.Configuration.LazyLoadingEnabled = false;
				resultado = ctx.Events
							//.Where(p => p.Id == id).FirstOrDefault();
							.FirstOrDefault(p => p.Id == id);
			}
			catch (Exception ex)
			{
				InternalServerError(ex);
			}

			return Ok(resultado);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				ctx.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
