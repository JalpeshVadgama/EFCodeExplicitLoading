using Microsoft.EntityFrameworkCore;

namespace EFCoreExplicitLoading
{
    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SQLServerName;Initial Catalog=YourDatabase;User ID=UserName;Password=Password;MultipleActiveResultSets=true");
        }
    }
}