using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ListItems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList1 = new List<Employee>
            {
                new Employee { Id = 1, Name = "John" },
                new Employee { Id = 4, Name = "Sarah" },
                new Employee { Id = 3, Name = "Penny" },
                new Employee { Id = 5, Name = "Sam" },
                new Employee { Id = 2, Name = "Paul" }
            };

            List<Employee> employeeList2 = new List<Employee>
            {
                new Employee { Id = 4, Name = "Leonard" },
                new Employee { Id = 7, Name = "Dave" },
                new Employee { Id = 3, Name = "Mary" },
                new Employee { Id = 5, Name = "Naomi" },
                new Employee { Id = 6, Name = "Kane" }
            };

            // Find the same Employee Ids between the two Employee lists
            foreach (var list1Employee in employeeList1)
            {
                foreach (var list2Employee in employeeList2)
                {
                    if (list1Employee.Id == list2Employee.Id)
                    {
                        Console.WriteLine($"{list1Employee.Name} - {list2Employee.Name}");
                    }
                }
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
