using Microsoft.EntityFrameworkCore;

namespace HealthCare.Doctors.Api.Models
{
    public class DoctorsDbContext : DbContext
    {
        public DoctorsDbContext(DbContextOptions<DoctorsDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
    }
}