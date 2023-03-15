using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, int age, double baseSalary)
        {
            Name = name;
            Age = age;
            BaseSalary = baseSalary;
        }

        public abstract void ShowEmployeeInfo();
        
    }
}
