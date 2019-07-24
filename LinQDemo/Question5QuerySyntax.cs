using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 5 query syntax")]
    class Question5QuerySyntax
    {
        static void Main()
        {
            var querySyntaxResult =
                from s in Collections.Students
                from c in Collections.Classes
                select new
                {
                    StudentId = s.Id,
                    ClassId = c.Id
                };

            foreach (var item in querySyntaxResult)
            {
                Console.WriteLine($"{item.StudentId}, {item.ClassId}");
            }
        }
    }
}
