using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ__22
{
    public class EmployeeManager : IReportGenerator
    {
        private List<Employee>[] employees;

        public EmployeeManager()
        {
            employees = new List<Employee>[4];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new List<Employee>();
            }
        }

        public void AddEmployee(Employee employee)
        {
            employees[(int)employee.Department].Add(employee);
        }

        public void DisplayEmployees(EmployeeHandler handler)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"employee Departament {((Department)i)}:");
                foreach (var employee in employees[i])
                {
                    handler(employee);
                }
                Console.WriteLine();
            }
        }

        public void GenerateReport()
        {
            Console.WriteLine("sotrudnic info:");
            DisplayEmployees(e => e.DisplayInfo());
        }
    }
}
