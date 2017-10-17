using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Data.Entity;
using AspnetMvcEvents.Data.Entities;

namespace AspnetMvcEvents.Services.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
		public int Edad { get; set; }
		public string Ocupacion { get; set; }


		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
			// Add custom user claims here
			userIdentity.AddClaim(new Claim("Oficina", "Panchitos Office"));
			userIdentity.AddClaim(new Claim("Ciudad", "Mexicali"));
			return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
		public DbSet<Event> Events { get; set; }
		public DbSet<Presenter> Presenters { get; set; }

		public ApplicationDbContext()
            : base("AspnetMvcEvents", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}