using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 1 method syntax")]
    class Question1MethodSyntax
    {
        static void Main()
        {
            var methodSyntaxResult1 = Collections.Classes
                .Select(c => new { c.Name, Count = Collections.Students.Count(s => s.ClassId == c.Id) });
            var methodSyntaxResult2 = Collections.Classes
                .GroupJoin(Collections.Students, c => c.Id, s => s.ClassId, (c, ss) => new { c.Name, Count = ss.Count() });

            Console.WriteLine("Solution 1");
            foreach (var item in methodSyntaxResult1)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }

            Console.WriteLine("Solution 2");
            foreach (var item in methodSyntaxResult2)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }
        }
    }
}
