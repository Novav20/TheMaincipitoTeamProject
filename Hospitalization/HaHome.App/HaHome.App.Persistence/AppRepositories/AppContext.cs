using HaHome.App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HaHome.App.Persistence.AppRepositories
{
    public class AppContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<VitalSign> VitalSigns { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<CareSuggestion> CareSuggestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HaHome.Data");
            }
        }
    }
}


