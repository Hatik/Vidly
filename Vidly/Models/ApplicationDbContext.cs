using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<MembershipType> MembershipTypes { get; set; }

        public System.Data.Entity.DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<Rental> Rentals { get; set; }
    }
}