using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 2 query syntax")]
    class Question2QuerySyntax
    {
        static void Main()
        {
            var querySyntaxResult =
                from s in Collections.Students
                group s by s.ClassId into g
                select new
                {
                    ClassId = g.Key,
                    Count = g.Count()
                };

            foreach (var item in querySyntaxResult)
            {
                Console.WriteLine($"{item.ClassId}, {item.Count}");
            }
        }
    }
}
