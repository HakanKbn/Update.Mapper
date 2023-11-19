using Microsoft.EntityFrameworkCore;

namespace Update.Mapper
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }
    }
}
