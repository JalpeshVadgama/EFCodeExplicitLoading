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
                    Console.WriteLine("Before explicit loading");
                    Console.WriteLine(department.Students==null);

                    //loading student explicitly
                    studentConext.Entry(department).Collection(s => s.Students).Load();

                    Console.WriteLine("After explicit loading");
                    Console.WriteLine(department.Students == null);
                    Console.WriteLine(department.Students.Count);
                    Console.WriteLine("------------------------------------------------");

                }
                Console.ReadLine();
            }
        }
    }
}