using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_Student
{
    class Module
    {
        private int moduleID;
        private List<Student> students = new List<Student>(); // dont use lists
        //use Student[] students;
        //then you can resize
        public Module(int aModuleID)
        {
            this.moduleID = aModuleID;
        }

        public int getModuleID()
        {
            return moduleID;
        }

        public void setModuleID(int moduleID)
        {
            this.moduleID = moduleID;
        }

        public List<Student> getStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

    }
}
