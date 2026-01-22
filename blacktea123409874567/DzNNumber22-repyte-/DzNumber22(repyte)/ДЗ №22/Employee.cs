using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ__22
{
    public enum Department
    {
        IT,
        HR,
        Finance,
        Marketing
    }

    public class Employee
    {
        public string Name { get; }
        public Department Department { get; }
        public decimal Salary { get; }

        public Employee(string name, Department department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Departament: {Department}, Salary: {Salary:C}");
        }
    }
}
