using System;
using Database.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database.EFCore
{
    public partial class ExampleContext : DbContext
    {
        public DbSet<CarModelEntity> CarModels { get; set; }
        public DbSet<CarEntity> Cars { get; set; }
        
        public ExampleContext()
        {
        }

        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;User ID=postgres;Password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<CarEntity>(entity =>
            {
                entity.ToTable("car");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<CarModelEntity>(entity =>
            {
                entity.ToTable("car_model");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).UseIdentityColumn();
                entity.HasOne(d => d.Car);
            });
            
            modelBuilder.Entity<CarEntity>().HasData(new CarEntity { Id = 1, Name = "BMW" });
            modelBuilder.Entity<CarEntity>().HasData(new CarEntity { Id = 2, Name = "Audi" });
            modelBuilder.Entity<CarEntity>().HasData(new CarEntity { Id = 3, Name = "Mercedes" });

            modelBuilder.Entity<CarModelEntity>().HasData(new
            {
                Id = 1, 
                Name = "M5",
                TypeEngine = "Petrol",
                CarId = 1
            });
            
            modelBuilder.Entity<CarModelEntity>().HasData(new
            {
                Id = 2, 
                Name = "RS7",
                TypeEngine = "Petrol",
                CarId = 2
            }); 
            
            modelBuilder.Entity<CarModelEntity>().HasData(new
            {
                Id = 3, 
                Name = "E63",
                TypeEngine = "Petrol",
                CarId = 3
            });
            
            modelBuilder.Entity<CarModelEntity>().HasData(new
            {
                Id = 4, 
                Name = "S63",
                TypeEngine = "Petrol",
                CarId = 3
            });
            
            modelBuilder.Entity<CarModelEntity>().HasData(new
            {
                Id = 5, 
                Name = "A5",
                TypeEngine = "Petrol",
                CarId = 2
            });
      }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
