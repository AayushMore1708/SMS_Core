using Microsoft.EntityFrameworkCore;
using SMS.Models;

namespace SMS_Core.Models
{
    public class SMSDbContext : DbContext
    {
        public SMSDbContext(DbContextOptions<SMSDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the primary key for tblStudentAdmission
            modelBuilder.Entity<tblStudentAdmission>()
                .HasKey(e => e.StudentAdmissionId);

            // Optional: If needed, configure other properties here
        }

        // Define your DbSets (tables) here
        public DbSet<tblStudentAdmission> tblStudentAdmission { get; set; }
    }
}
