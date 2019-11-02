using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_Student
{
    class Student
    {
        private String name;
        private int studentID;
        private int moduleCode;
    
        public Student(String aName, int aStudentID, int aModuleCode)
        {
            this.name = aName;
            this.studentID = aStudentID;
            this.moduleCode = aModuleCode;
        }
        public Student(String aName, int aStudentID)
        {
            this.name = aName;
            this.studentID = aStudentID;
        }
        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getStudentID()
        {
            return studentID;
        }

        public void setStudentID(int studentID)
        {
            this.studentID = studentID;
        }

        public int getModuleCode()
        {
            return moduleCode;
        }

        public void setModuleCode(int moduleCode)
        {
            this.moduleCode = moduleCode;
        }


    }
}
