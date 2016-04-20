using Hogwarts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SchoolContext context=new SchoolContext())
            {
                int antalStudenter = context.Students.Count();
                Console.WriteLine("Antal studenter: "+antalStudenter);

                foreach (Student s in context.Students)
                {
                    if (s.CurrentCourse == null)
                        Console.WriteLine("Student: " + s.Name +
                            ", no course");
                    else
                        Console.WriteLine("Student: " + s.Name +
                            ", current course: " + s.CurrentCourse.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
