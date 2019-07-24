using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 5 method syntax")]
    class Question5MethodSyntax
    {
        static void Main()
        {
            var methodSyntaxResult = Collections.Students
                .Join(Collections.Classes, s => true, c => true, (s, c) => new { StudentId = s.Id, ClassId = c.Id });

            foreach (var item in methodSyntaxResult)
            {
                Console.WriteLine($"{item.StudentId}, {item.ClassId}");
            }
        }
    }
}
