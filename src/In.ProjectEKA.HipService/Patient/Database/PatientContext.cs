using In.ProjectEKA.HipService.Migrations;
using Microsoft.EntityFrameworkCore;

namespace In.ProjectEKA.HipService.Patient.Database
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {
        }

        public DbSet<PatientQueue> PatientQueue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientQueue>(builder =>
            {
                builder.HasKey(p => p.RequestId);
                builder.Property(p => p.RequestId);
                builder.Property(p => p.DateTimeStamp);
                builder.Property(p => p.Profile);
            });
        }

    }
}