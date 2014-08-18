using Microsoft.AspNet.Identity.EntityFramework;
using NinjaTurtlesApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTurtlesApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<NinjaTurtle> Turtles { get; set; }
     
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
