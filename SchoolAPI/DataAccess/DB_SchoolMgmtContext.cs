using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolAPI.DataAccess
{
    public partial class DB_SchoolMgmtContext : DbContext
    {
        public DB_SchoolMgmtContext()
        {
        }

        public DB_SchoolMgmtContext(DbContextOptions<DB_SchoolMgmtContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAboutUsMaster> TblAboutUsMasters { get; set; } = null!;
        public virtual DbSet<TblAdminLogin> TblAdminLogins { get; set; } = null!;
        public virtual DbSet<TblBannerMaster> TblBannerMasters { get; set; } = null!;
        public virtual DbSet<TblCourseMaster> TblCourseMasters { get; set; } = null!;
        public virtual DbSet<TblGalleryMaster> TblGalleryMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PANKAJ\\SQLEXPRESS;Initial Catalog=DB_SchoolMgmt;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAboutUsMaster>(entity =>
            {
                entity.ToTable("Tbl_AboutUsMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AboutUsHeading).HasMaxLength(150);

                entity.Property(e => e.AboutsFileName).HasMaxLength(100);

                entity.Property(e => e.AboutsFilePath).HasMaxLength(100);

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAdminLogin>(entity =>
            {
                entity.ToTable("Tbl_AdminLogin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(20);
            });

            modelBuilder.Entity<TblBannerMaster>(entity =>
            {
                entity.ToTable("Tbl_BannerMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.BannerHeading).HasMaxLength(150);

                entity.Property(e => e.BannerImage).HasMaxLength(100);

                entity.Property(e => e.BannerPath).HasMaxLength(100);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCourseMaster>(entity =>
            {
                entity.ToTable("Tbl_CourseMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.CourseFileName).HasMaxLength(100);

                entity.Property(e => e.CourseFilePath).HasMaxLength(100);

                entity.Property(e => e.CourseName).HasMaxLength(150);

                entity.Property(e => e.CoursePunchLine).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGalleryMaster>(entity =>
            {
                entity.ToTable("Tbl_GalleryMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.GalleryFileName).HasMaxLength(100);

                entity.Property(e => e.GalleryFilePath).HasMaxLength(100);

                entity.Property(e => e.GalleryPunchLine).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
