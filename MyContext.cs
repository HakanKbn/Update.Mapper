using Microsoft.EntityFrameworkCore;
using Update.Mapper.Model;

namespace Update.Mapper;

public class MyContext : DbContext
{
    public DbSet<Referans> Referans { get; set; }

    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
      

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Referans>().HasNoKey();
        modelBuilder.Entity<Referans>().HasIndex(x => new { x.tenantId, x.kod, x.tipId }).IsUnique();

        
    }
}