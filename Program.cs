using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student dan = new Student("Dan", 123, 3422);
            Student john = new Student("John", 5);
            Console.WriteLine(dan.getName() + " " + dan.getStudentID() );
            Module soft152 = new Module(22);
            soft152.AddStudent(dan);
            soft152.AddStudent(john);

            List<Student> studentList = soft152.getStudents();
            foreach(Student student in studentList)
            {
                Console.WriteLine(student.getName());
            }
            Console.ReadKey();
        }
    }
}
