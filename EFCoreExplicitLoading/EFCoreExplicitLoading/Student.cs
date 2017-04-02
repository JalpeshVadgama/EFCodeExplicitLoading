namespace EFCoreExplicitLoading
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartMentId { get; set; }
        public Department Department { get; set; }
    }
}