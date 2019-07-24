using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 4 query syntax")]
    class Question4QuerySyntax
    {
        static void Main()
        {
            var querySyntaxResult =
                from c in Collections.Classes
                join s in Collections.Students
                on c.Id equals s.ClassId into ss
                select new
                {
                    ClassName = c.Name,
                    FirstStudentName = ss.FirstOrDefault()?.Name ?? "null"
                };

            Console.WriteLine("Solution 1");
            foreach (var item in querySyntaxResult)
            {
                Console.WriteLine($"{item.ClassName}, {item.FirstStudentName}");
            }
        }
    }
}
