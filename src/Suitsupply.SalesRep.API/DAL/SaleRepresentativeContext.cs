using Microsoft.EntityFrameworkCore;
using Suitsupply.SalesRep.API.DAL.Entities;

namespace Suitsupply.SalesRep.API.DAL
{
    public class SaleRepresentativeContext : DbContext
    {
        public DbSet<SaleRepresentative> SalesRepresentatives { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("ConnectionString");
        }
    }
}