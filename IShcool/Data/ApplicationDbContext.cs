using IShcool.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Test.Models;
using The_Top_App.Models;

namespace IShcool.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Enrollment>()
            .HasKey(b => new { b.TeacherId, b.StudentId });

            builder.Entity<Chapter>()
            .HasKey(b => new { b.TeacherId, b.Title });

            builder.Entity<Lesson>()
            .HasKey(b => new { b.TeacherId, b.ChapterTitle, b.Title });

            builder.Entity<LessonTest>()
            .HasKey(b => new { b.Vedio_Url, b.Quest });

            builder.Entity<LTestResult>()
            .HasKey(b => new { b.Vedio_Url, b.StudentId });

            builder.Entity<GeneralExam>()
           .HasKey(b => new { b.TeacherId, b.Title, b.Academy_Year });

            builder.Entity<GeneralExamQuestion>()
           .HasKey(b => new { b.TeacherId, b.ExamTitle, b.Academy_Year, b.Quest});

            builder.Entity<GeneralExamResult>()
           .HasKey(b => new { b.TeacherId, b.ExamTitle, b.StudentId });

            builder.Entity<Book>()
           .HasKey(b => new { b.TeacherId, b.Title, b.Academy_Year });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonTest> LessonsTest { get; set; }

        public DbSet<LTestResult> LTestResults { get; set; }

        public DbSet<GeneralExam> GeneralExams { get; set; }

        public DbSet<GeneralExamQuestion> GeneralExamQuestions { get; set; }

        public DbSet<GeneralExamResult> GeneralExamResults { get; set;}

        public DbSet<Book> Books { get; set; }

        public DbSet<Subject> Subjects { get; set; }
    }
}