using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Grades> Grades{ get; set; }

    }
}
