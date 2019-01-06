using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseFirstEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            PlutoDbContext dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Description);
                Thread.Sleep(5000);
            }

        }
    }
}
