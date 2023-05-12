using DataStorage.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataStorage
{
    public class Context : DbContext
    {
        public DbSet<FeatureEntity> Features { get; set; }
        public DbSet<GeometryEntity> Geometries { get; set; }
        public DbSet<LinkEntity> Links { get; set; }
        public DbSet<PropertiesEntity> Properties { get; set; }
        public DbSet<RootEntity> Roots { get; set; }

        public Context()
        {
            
        }
        public Context(DbContextOptions builder) : base(builder) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-HPD38H10\\SQLEXPRESS;Database=BigData;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Root

            modelBuilder.Entity<RootEntity>()
                .ToTable("Root");

            modelBuilder.Entity<RootEntity>()
                .HasKey(r => r.RootId)
                .HasName("root_id");

            modelBuilder.Entity<RootEntity>()
                .Property(r => r.Type)
                .HasColumnName("type");

            modelBuilder.Entity<RootEntity>()
                .Property(r => r.TimeStamp)
                .HasColumnName("time_stamp");

            modelBuilder.Entity<RootEntity>()
                .Property(r => r.NumberReturned)
                .HasColumnName("number_returned");

            #endregion

            #region Feature

            modelBuilder.Entity<FeatureEntity>()
                .ToTable("Feature");
                
            modelBuilder.Entity<FeatureEntity>()
                .HasKey(f => f.FeatureId)
                .HasName("feature_id");

            modelBuilder.Entity<FeatureEntity>()
                .Property(f => f.FeatureNumber)
                .HasColumnName("fearture_number");
                
            modelBuilder.Entity<FeatureEntity>()
                .Property(f => f.Type)
                .HasColumnName("type")
                .HasMaxLength(25);

            #endregion

            #region Link

            modelBuilder.Entity<LinkEntity>()
                .ToTable("Link");

            modelBuilder.Entity<LinkEntity>()
                .HasKey(l => l.LinkId)
                .HasName("link_id");
            
            modelBuilder.Entity<LinkEntity>()
              .Property(l => l.Title)
              .HasColumnName("title");

            modelBuilder.Entity<LinkEntity>()
              .Property(l => l.Type)
              .HasColumnName("type")
              .HasMaxLength(25);

            modelBuilder.Entity<LinkEntity>()
                .Property(l => l.Href)
                .HasColumnName("href");

            modelBuilder.Entity<LinkEntity>()
              .Property(l => l.Rel)
              .HasColumnName("rel");

            #endregion

            #region Properties

            modelBuilder.Entity<PropertiesEntity>()
                .ToTable("Properti");

            modelBuilder.Entity<PropertiesEntity>().HasKey(p => p.PropertiesId).HasName("propeti_id");

            modelBuilder.Entity<PropertiesEntity>()
                .Property(p => p.ParameterNumber)
                .HasColumnName("parameter_number");
    
            modelBuilder.Entity<PropertiesEntity>()
                .Property(p => p.Created)
                .HasColumnName("created");

            modelBuilder.Entity<PropertiesEntity>()
                .Property(p => p.Observed)
                .HasColumnName("observed");

            modelBuilder.Entity<PropertiesEntity>()
                .Property(p => p.StationNumber)
                .HasColumnName("station_number");

            modelBuilder.Entity<PropertiesEntity>()
                .Property(p => p.Value)
                .HasColumnName("value");

            #endregion

            #region Geometry

            modelBuilder.Entity<GeometryEntity>()
                .ToTable("Geometry");

            modelBuilder.Entity<GeometryEntity>()
                .HasKey(g => g.GeometryId)
                .HasName("geometry_id");

            modelBuilder.Entity<GeometryEntity>()
                .Property(g => g.Type)
                .HasColumnName("type");

            #endregion

            #region Coordinate

            modelBuilder.Entity<CoordinateEntity>()
                .ToTable("Coordinate");


            modelBuilder.Entity<CoordinateEntity>()
                .HasKey(c => c.CoordinateId)
                .HasName("coordinate_id");

            modelBuilder.Entity<CoordinateEntity>()
                .Property(c => c.Value)
                .HasColumnName("value");

            #endregion

            #region OneToMany

            modelBuilder.Entity<FeatureEntity>()
                .HasOne(f => f.Geometry)
                .WithMany(g => g.Features)
                .HasForeignKey(f => f.Fk_GeometryId);

            modelBuilder.Entity<FeatureEntity>()
                .HasOne(f => f.Properties)
                .WithOne(p => p.Feature)
                .HasForeignKey<FeatureEntity>(f => f.FK_PropertiesId);

            modelBuilder.Entity<CoordinateEntity>()
                .HasOne(c => c.Geometry)
                .WithMany(g => g.Coordinates)
                .HasForeignKey(c => c.FK_GemoetryId);

            modelBuilder.Entity<LinkEntity>()
                .HasOne(l => l.Root)
                .WithMany(r => r.Links)
                .HasForeignKey(l => l.FK_RootId);

            modelBuilder.Entity<FeatureEntity>()
                .HasOne(f => f.Root)
                .WithMany(r => r.Features)
                .HasForeignKey(f => f.FK_RootId);

            #endregion
        }

    }
}