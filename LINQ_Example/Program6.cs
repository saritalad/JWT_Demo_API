using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example
{
    internal class Program6
    {
        public static void Main()
        {

            var query = Student.GetStudents().GroupBy(s => s.Branch);

            foreach (var gp in query)
            {
                Console.WriteLine(gp.Key + "  " + gp.Count());
                Console.WriteLine("\n......................\n");
                foreach (Student s in gp)
                    Console.WriteLine(s.ID + "  " + s.Name + "  " + s.Branch);
            }



        }
    }
}
