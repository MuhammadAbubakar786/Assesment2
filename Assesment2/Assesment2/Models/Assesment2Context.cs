using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assesment2.Models
{
    public partial class Assesment2Context : DbContext
    {
        public Assesment2Context()
        {
        }

        public Assesment2Context(DbContextOptions<Assesment2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriesManagement> CategoriesManagement { get; set; }
        public virtual DbSet<ItemManagement> ItemManagement { get; set; }
        public virtual DbSet<UsersManagement> UsersManagement { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-SLUGB16;Database=Assesment2;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriesManagement>(entity =>
            {
                entity.ToTable("Categories_Management");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemManagement>(entity =>
            {
                entity.ToTable("Item_Management");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategorieId)
                    .HasColumnName("Categorie_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CostPrice).HasColumnName("Cost_Price");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.MainColor).HasMaxLength(50);

                entity.Property(e => e.MainImage).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SalePrice).HasColumnName("Sale_Price");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<UsersManagement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.ProfilePicture).HasMaxLength(50);

                entity.Property(e => e.RegisteredData).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
