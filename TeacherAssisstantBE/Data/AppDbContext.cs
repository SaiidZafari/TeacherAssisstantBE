using Microsoft.EntityFrameworkCore;
using TeacherAssisstantBE.Models;

namespace TeacherAssisstantBE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Option)
           : base(Option)
        {

        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Answer> Answer { get; set; }

        public DbSet<Lecture> Lecture { get; set; }

        public DbSet<Article> Article { get; set; }

        public DbSet<Result> Result { get; set; }

        public DbSet<SelectedAnswer> SelectedAnswer { get; set; }
    }
}
