using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 2 method syntax")]
    class Question2MethodSyntax
    {
        static void Main()
        {
            var methodSyntaxResult = Collections.Students
                .GroupBy(s => s.ClassId)
                .Select(g => new { ClassId = g.Key, Count = g.Count() });
                //.Where(i => i.Count > 0);

            foreach (var item in methodSyntaxResult)
            {
                Console.WriteLine($"{item.ClassId}, {item.Count}");
            }
        }
    }
}
