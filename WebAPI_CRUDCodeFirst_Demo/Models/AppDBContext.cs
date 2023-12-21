using Microsoft.EntityFrameworkCore;

namespace WebAPI_CRUDCodeFirst_Demo.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) { }
       

        public DbSet<Employee>?Employees { get; set; }

    }
}
