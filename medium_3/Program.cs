using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medium_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emply = new Employee();
            emply.Insert_emply_details();
            emply.SortAndPrintEmployees();
            emply.PrintEmployee();
            Console.ReadKey();

        }
    }
}
