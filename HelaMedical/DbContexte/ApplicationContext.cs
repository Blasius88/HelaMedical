using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelaMedical.Class;

namespace HelaMedical
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("HelaMedical")
        {
        }
        public DbSet<Alco> Alcos { get; set; }

        public DbSet<Narcoman> Narcomans { get; set; }

        public DbSet<Polizavis> Polizaviss { get; set; }

        public DbSet<Incitalization> Incitalizations { get; set; }
    }
}