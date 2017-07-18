using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    public class Course
    {
        public static void Main()
        {
            InnerCourse innerCourse = new InnerCourse("Databases", "Svetlin Nakov",
                new List<string>() { "Peter", "Maria", "Milena", "Todor" }, "Enterprise");
            Console.WriteLine(innerCourse);

            OutsideCourse outsideCourse = new OutsideCourse("PHP and WordPress Development", "Mario Peshev",
                new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(outsideCourse);
        }
    }
}
