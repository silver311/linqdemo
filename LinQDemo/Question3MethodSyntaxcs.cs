using System;
using System.ComponentModel;
using System.Linq;
using LinQDemo.Models;

namespace LinQDemo
{
    [Description("Question 3 method syntax")]
    class Question3MethodSyntaxcs
    {
        static void Main()
        {
            var methodSyntaxResult = Collections.Students
                .GroupBy(s => s.ClassId)
                .Select(g => new { ClassId = g.Key, Count = g.Count() })
                .Join(Collections.Classes, g => g.ClassId, c => c.Id, (g, c) => new { c.Name, g.Count })
                .Where(i => i.Count > 0);

            foreach (var item in methodSyntaxResult)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }
        }
    }
}
