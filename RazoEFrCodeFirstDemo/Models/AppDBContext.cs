using Microsoft.EntityFrameworkCore;

namespace RazoEFrCodeFirstDemo.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {
            
        }

        public DbSet<Employee>?Employees { get; set; }
        public DbSet<Department> Departments { get; set; } 
    }
}
