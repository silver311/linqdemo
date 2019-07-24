using LinQDemo.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace LinQDemo
{
    [Description("Question 3 query syntax")]
    class Question3QuerySyntax
    {
        static void Main()
        {
            var querySyntaxResult =
                from g in
                    from s in Collections.Students
                    group s by s.ClassId into g
                    select new
                    {
                        ClassId = g.Key,
                        Count = g.Count()
                    }
                join c in Collections.Classes
                on g.ClassId equals c.Id
                select new
                {
                    c.Name,
                    g.Count
                };

            var shorterVersion =
                from r in
                    from c in Collections.Classes
                    select new
                    {
                        c.Name,
                        Count = Collections.Students.Count(i => i.ClassId == c.Id)
                    }
                where r.Count > 0
                select r;

            var query = from s in Collections.Students
                        join c in Collections.Classes
                        on s.ClassId equals c.Id
                        group s by new { s.ClassId, c.Name } into ss
                        select new
                        {
                            ss.Key.Name,
                            Count = ss.Count()
                        };

            foreach (var item in querySyntaxResult)
            {
                Console.WriteLine($"{item.Name}, {item.Count}");
            }
        }
    }
}
