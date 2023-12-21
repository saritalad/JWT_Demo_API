using Microsoft.EntityFrameworkCore;

namespace WebAPICRUD_DBFirst.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) { }
       



        public DbSet<Product> Products {  get; set; }
    }
}
