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

        // Define your DbSets (tables) here
        public DbSet<Student> Students { get; set; }
    }
}
