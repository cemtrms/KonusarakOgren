using ExamKnsrkOgrnApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamKnsrkOgrnApp.SQLite
{
    public class SQLiteDBContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<TakenExam> TakenExams { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=sqlitedemo.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>()
            .HasKey(c => c.Id);
            modelBuilder.Ignore<Entity>();
        }
    }
}
