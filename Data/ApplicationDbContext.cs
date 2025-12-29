using Microsoft.EntityFrameworkCore;
using studentManagentSystem_291225_.Models;

namespace studentManagentSystem_291225_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
