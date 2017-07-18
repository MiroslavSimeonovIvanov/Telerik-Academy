using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class InnerCourse : Course
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

                if (name == null || name.Length == 0)
                {
                    throw new NullReferenceException("You should enter a name of the course.");
                }
            }
        }

        private string teacherName;
        public string TeacherName
        {
            get
            {
                return teacherName;
            }
            set
            {
                teacherName = value;

                if (teacherName == null || teacherName.Length == 0)
                {
                    throw new NullReferenceException("You should enter teacher's name.");
                }
            }
        }

        private List<string> students;
        public List<string> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;

                if (students == null || students.Count == 0)
                {
                    throw new NullReferenceException("Please enter the students.");
                }
            }
        }

        private string lab;
        public string Lab
        {
            get
            {
                return lab;
            }
            set
            {
                lab = value;

                if (lab == null || lab.Length == 0)
                {
                    throw new NullReferenceException("Laboratory should be entered.");
                }
            }
        }

        public InnerCourse(string courseName, string teacherName, List<string> students, string laboratory)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Lab = laboratory;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("InnerCourse { Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.Students);

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
