using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medium_3
{
    class Employee
    {
        IDictionary<int, Tuple<string, int, double>> employe = new Dictionary<int, Tuple<string, int, double>>();
        int id, age;
        string name;
        double salary;
        int opt;

        public Employee()
        {

        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }
        public void Get_emplydetails()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }


        public void Insert_emply_details()
        {
            do
            {
                Get_emplydetails();
                employe.Add(id, Tuple.Create(name, age, salary));
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                opt = Convert.ToInt32(Console.ReadLine());
            } while (opt == 1);



        }
        public void SortAndPrintEmployees()
        {
            Console.WriteLine("The sorted employee list");
            foreach (var emp in employe.OrderBy(key => key.Value.Item3))
            {

                Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", emp.Key, emp.Value.Item1, emp.Value.Item2, emp.Value.Item3);
                Console.WriteLine("-------------------------------");


            }
        }
        public void PrintEmployee()
        {
            string name1;
            Console.WriteLine("Please enter the employee name");
            name1 = Console.ReadLine();
            foreach(var emp in employe)
            {
                if(name1==emp.Value.Item1)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", emp.Key, emp.Value.Item1, emp.Value.Item2, emp.Value.Item3);
                    continue;
                }
            }


        }
    }


}

