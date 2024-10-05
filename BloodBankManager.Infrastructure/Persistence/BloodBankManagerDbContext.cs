
using BloodBankManager.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BloodBankManager.Persistence
{
    public class BloodBankManagerDbContext: DbContext
    {
        public BloodBankManagerDbContext(DbContextOptions<BloodBankManagerDbContext>options):base(options) 
        {
            
        }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<BloodStorage> BloodStorages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
           
        
    }
}
