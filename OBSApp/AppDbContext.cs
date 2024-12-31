using Microsoft.EntityFrameworkCore;
using OBSApp.Models;

public class AppDbContext : DbContext
{
    public DbSet<Sinif> Siniflar { get; set; }
    public DbSet<Ders> Dersler { get; set; }
    public DbSet<Ogrenci> Ogrenciler { get; set; }
    public DbSet<OgrenciDers> OgrenciDersler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Data Source=FURKAN; Initial Catalog=OBS; Integrated Security=true; TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Ogrenci>()
                    .HasIndex(o => o.Numara)
                    .IsUnique();


        
        modelBuilder.Entity<OgrenciDers>()
            .HasKey(od => new { od.DersId, od.OgrenciId });

        modelBuilder.Entity<OgrenciDers>()
            .HasOne(od => od.Ogrenci)
            .WithMany(o => o.OgrenciDersler)
            .HasForeignKey(od => od.OgrenciId);

        modelBuilder.Entity<OgrenciDers>()
            .HasOne(od => od.Ders)
            .WithMany(d => d.OgrenciDersler)
            .HasForeignKey(od => od.DersId);

        
        modelBuilder.Entity<Ders>().HasData(
            new Ders { DersId = 1, DersKod = "BİL201", DersAd = "İnternet Programcılığı" },
            new Ders { DersId = 2, DersKod = "BİL202", DersAd = "Nesne Tabanlı Programlama" },
            new Ders { DersId = 3, DersKod = "BİL203", DersAd = "Veri Tabanı Ve Yönetimi" },
            new Ders { DersId = 4, DersKod = "BİL204", DersAd = "Görsel Programlama" },
            new Ders { DersId = 5, DersKod = "BİL205", DersAd = "Adli Bilişim" },
            new Ders { DersId = 6, DersKod = "BİL206", DersAd = "İngilizce" },
            new Ders { DersId = 7, DersKod = "BİL207", DersAd = "Matematik" },
            new Ders { DersId = 8, DersKod = "BİL208", DersAd = "İş Sağlığı Ve Güvenliği" }
               
        ); ;
    }
}
