using System;
using System.Linq;

namespace EFCoreExplicitLoading
{
    class Program
    {

        static void Main(string[] args)
        {
            using(StudentContext studentConext= new StudentContext())
            {
                var deaprtments = studentConext.Departments.ToList();
                foreach(var department in deaprtments)
                {
                   
                    Console.WriteLine(department.Students==null);

                    //loading student explicitly
                    studentConext.Entry(department).Reference(s => s.Students).Load();

                    Console.WriteLine(department.Students == null);
                    Console.WriteLine(department.Students.Count);

                }
                Console.ReadLine();
            }
        }
    }
}