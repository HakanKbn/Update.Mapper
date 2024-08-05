using Microsoft.EntityFrameworkCore;
using Update.Mapper.Model;

namespace Update.Mapper;

public class MyContext : DbContext
{
    public DbSet<BaseHareket> BaseHareket { get; set; }
    public DbSet<BelgeBaslik> BelgeBaslik { get; set; }
    public DbSet<BelgeEkler> BelgeEk { get; set; }
    public DbSet<CariBelge> CariBelge { get; set; }
    public DbSet<CariHareket> CariHareket { get; set; }
    public DbSet<FaturaBelge> FaturaBelge { get; set; }
    public DbSet<HareketEkler> HareketEk { get; set; }
    public DbSet<IrsaliyeBelge> IrsaliyeBelge { get; set; }
    public DbSet<SatisBelge> SatisSatinAlma { get; set; }
    public DbSet<SiparisHareket> SiparisHareket { get; set; }
    public DbSet<StokBelge> StokBelge { get; set; }
    public DbSet<StokHareket> StokHareket { get; set; }
    public DbSet<HareketVergi> HareketVergiler { get; set; }
    public DbSet<HareketIskonto> HareketIskontolar { get; set; }
    public DbSet<SiparisBelge> SiparisBelge { get; set; }
    public DbSet<BelgeIskonto> BelgeIskonto { get; set; }
    public DbSet<BelgeVergi> BelgeVergi { get; set; }



    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
      

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseHareket>().ToTable(nameof(BaseHareket));
        modelBuilder.Entity<BelgeBaslik>().HasMany(x => x.BelgeEkler).WithOne().HasForeignKey(x => x.BelgeId);
        modelBuilder.Entity<BelgeBaslik>().HasMany(x => x.StokHareketler).WithOne().HasForeignKey(x => x.BelgeId);
        modelBuilder.Entity<BelgeBaslik>().HasMany(x => x.CariHareketler).WithOne().HasForeignKey(x => x.BelgeId);
        modelBuilder.Entity<BelgeBaslik>().HasMany(x => x.SiparisHareketler).WithOne().HasForeignKey(x => x.BelgeId);
        modelBuilder.Entity<StokBelge>().ToTable(nameof(StokBelge));
        modelBuilder.Entity<CariBelge>().ToTable(nameof(CariBelge));
        modelBuilder.Entity<SatisBelge>().ToTable(nameof(SatisBelge));
        modelBuilder.Entity<SiparisBelge>().ToTable(nameof(SiparisBelge));
        modelBuilder.Entity<IrsaliyeBelge>().ToTable(nameof(IrsaliyeBelge));
        modelBuilder.Entity<FaturaBelge>().ToTable(nameof(FaturaBelge));
        modelBuilder.Entity<StokHareket>().ToTable(nameof(StokHareket));
        modelBuilder.Entity<CariHareket>().ToTable(nameof(CariHareket));
        modelBuilder.Entity<SiparisHareket>().ToTable(nameof(SiparisHareket));
        modelBuilder.Entity<HareketIskonto>().ToTable(nameof(HareketIskonto));
        modelBuilder.Entity<HareketVergi>().ToTable(nameof(HareketVergi));
        modelBuilder.Entity<BelgeIskonto>().ToTable(nameof(BelgeIskonto));
        modelBuilder.Entity<BelgeVergi>().ToTable(nameof(BelgeVergi));
        modelBuilder.Entity<BaseHareket>().HasMany(x => x.HareketEkler).WithOne().HasForeignKey(x => x.HareketId);
        modelBuilder.Entity<BaseHareket>().HasMany(x => x.HareketIskontolar).WithOne().HasForeignKey(x => x.HareketId);
        modelBuilder.Entity<BaseHareket>().HasMany(x => x.HareketVergiler).WithOne().HasForeignKey(x => x.HareketId);
        modelBuilder.Entity<SatisBelge>().HasMany(x => x.BelgeIskontolar).WithOne().HasForeignKey(x => x.BelgeId);
        modelBuilder.Entity<SatisBelge>().HasMany(x => x.BelgeVergiler).WithOne().HasForeignKey(x => x.BelgeId);
    }
}