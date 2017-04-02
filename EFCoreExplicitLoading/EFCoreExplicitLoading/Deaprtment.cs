using System.Collections.Generic;

namespace EFCoreExplicitLoading
{
    public class Deaprtment
    {
        public int Department { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}