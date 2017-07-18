using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OutsideCourse : Course
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

        private string town;
        public string Town
        {
            get
            {
                return town;
            }
            set
            {
                town = value;
            }
        }

        public OutsideCourse(string courseName, string teacherName, List<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Town = null;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OutsideCourse { Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.Students);

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
