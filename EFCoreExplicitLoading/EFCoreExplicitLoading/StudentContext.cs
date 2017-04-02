using Microsoft.EntityFrameworkCore;

namespace EFCoreExplicitLoading
{
    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Deaprtment> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=FSS1;Initial Catalog=Student;User ID=sa;Password=Jalpesh@123;MultipleActiveResultSets=true");
        }
    }
}