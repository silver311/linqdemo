using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 1 query syntax")]
    class Question1QuerySyntax
    {
        static void Main()
        {
            var querySyntaxResult1 =
                from c in Collections.Classes
                select new
                {
                    c.Name,
                    Count = Collections.Students.Count(s => s.ClassId == c.Id)
                };
            var querySyntaxResult2 =
                from c in Collections.Classes
                join s in Collections.Students
                on c.Id equals s.ClassId into ss
                select new
                {
                    c.Name,
                    Count = ss.Count()
                };

            Console.WriteLine("Solution 1");
            foreach (var item in querySyntaxResult1)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }

            Console.WriteLine("Solution 2");
            foreach (var item in querySyntaxResult2)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }
        }
    }
}
