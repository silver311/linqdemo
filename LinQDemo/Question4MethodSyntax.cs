using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 4 method syntax")]
    class Question4MethodSyntax
    {
        static void Main()
        {
            var methodSyntaxResult1 = Collections.Classes
                .GroupJoin(Collections.Students, c => c.Id, s => s.ClassId, (c, ss) => new
                {
                    ClassName = c.Name,
                    FirstStudentName = ss.FirstOrDefault()?.Name ?? "null"
                });
            var methodSyntaxResult2 = Collections.Classes
                .Select(c => new
                {
                    ClassName = c.Name,
                    FirstStudentName = Collections.Students.FirstOrDefault(s => s.ClassId == c.Id)?.Name ?? "null"
                });
            Console.WriteLine("Solution 1");
            foreach (var item in methodSyntaxResult1)
            {
                Console.WriteLine($"{item.ClassName}, {item.FirstStudentName}");
            }
            Console.WriteLine("Solution 2");
            foreach (var item in methodSyntaxResult2)
            {
                Console.WriteLine($"{item.ClassName}, {item.FirstStudentName}");
            }
        }
    }
}
