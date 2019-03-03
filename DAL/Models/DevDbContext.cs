using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class DevDbContext : DbContext
    {
        public DevDbContext()
        {
        }

        public DevDbContext(DbContextOptions<DevDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classrooms> Classrooms { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=KALYAN-PC;Database=SchoolManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview.19074.3");

            modelBuilder.Entity<Classrooms>(entity =>
            {
                entity.HasKey(e => e.RoomNo);

                entity.Property(e => e.RoomNo).HasColumnName("Room_no");

                entity.Property(e => e.Floor)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK_Course");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CourseName)
                    .HasColumnName("Course_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => new { e.DayOfWeek, e.RoomNo, e.StartTime, e.EndTime });

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("Day_of_Week")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNo).HasColumnName("Room_no");

                entity.Property(e => e.StartTime).HasColumnName("Start_Time");

                entity.Property(e => e.EndTime).HasColumnName("End_Time");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("Fk_Course_Id");

                entity.HasOne(d => d.RoomNoNavigation)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.RoomNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Room_no");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => new { e.RollNo, e.Standard });

                entity.Property(e => e.RollNo).HasColumnName("Roll_no");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasColumnName("Student_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
