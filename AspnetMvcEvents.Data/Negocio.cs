using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AspnetMvcEvents.Data
{
	public class Negocio
	{
		public bool VerificarIdentidad()
		{
			try
			{
				var principal = Thread.CurrentPrincipal as ClaimsPrincipal;
				var oficina = principal.Claims.Where(p => p.Type == "Oficina").FirstOrDefault().Value;
				return true;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
