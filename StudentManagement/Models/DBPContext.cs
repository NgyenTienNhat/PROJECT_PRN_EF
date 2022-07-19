using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace StudentManagement.Models
{
    public partial class DBPContext : DbContext
    {
        public DBPContext()
        {
        }

        public DBPContext(DbContextOptions<DBPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAttendence> StudentAttendences { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectStudent> SubjectStudents { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherAttendence> TeacherAttendences { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account");

                entity.Property(e => e.AccountId).ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RollNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Student__ClassId__29572725");
            });

            modelBuilder.Entity<StudentAttendence>(entity =>
            {
                entity.ToTable("StudentAttendence");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.RollNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentAttendences)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__StudentAt__Class__35BCFE0A");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.StudentAttendences)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__StudentAt__Subje__36B12243");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubjectStudent>(entity =>
            {
                entity.ToTable("SubjectStudent");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SubjectStudents)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_SubjectStudent_Class");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SubjectStudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_SubjectStudent_Student");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectStudents)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_SubjectStudent_Subject");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherName).HasMaxLength(30);
            });

            modelBuilder.Entity<TeacherAttendence>(entity =>
            {
                entity.ToTable("TeacherAttendence");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherAttendences)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TeacherAttendence_Teacher");
            });

            modelBuilder.Entity<TeacherSubject>(entity =>
            {
                entity.ToTable("TeacherSubject");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__TeacherSu__Class__2E1BDC42");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__TeacherSu__Subje__2F10007B");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TeacherSubject_Teacher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
