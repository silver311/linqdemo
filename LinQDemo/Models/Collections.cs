using System.Collections.Generic;

namespace LinQDemo.Models
{
    public static class Collections
    {
        private static List<Student> students;
        private static List<Class> classes;

        public static List<Student> Students
        {
            get
            {
                if (students == null)
                {
                    students = new List<Student>()
                    {
                        new Student() { Id = 11, Name = "st1", ClassId = 1 },
                        new Student() { Id = 12, Name = "st2", ClassId = 1 },
                        new Student() { Id = 13, Name = "st3", ClassId = 2 }
                    };
                }
                return students;
            }
        }

        public static List<Class> Classes
        {
            get
            {
                if (classes == null)
                {
                    classes = new List<Class>()
                    {
                        new Class() { Id = 1, Name = "c1" },
                        new Class() { Id = 2, Name = "c2" },
                        new Class() { Id = 3, Name = "c3" }
                    };
                }
                return classes;
            }
        }
    }
}
