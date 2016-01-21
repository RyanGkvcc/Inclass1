using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Here is some text");
            //Console.WriteLine("Here is some more text");
            //Console.ReadKey();
            // Control F5 to run and pause automatically

            Employee employee = new Employee("Dave", "Barnes", 537.00m);
            Employee employee2 = new Employee("Joe", "Somebody", 125.50m);

            Console.WriteLine(employee.GetFullName());
            Console.WriteLine(employee.ToString());
        }
    }
}
