using System.Collections.Generic;

namespace EFCoreExplicitLoading
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}