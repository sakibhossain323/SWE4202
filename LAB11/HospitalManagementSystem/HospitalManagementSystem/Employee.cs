using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string address, string phoneNum, string email, DateTime hireDate)
        {
            Name = name;
            Address = address;
            PhoneNum = phoneNum;
            Email = email;
            HireDate = hireDate;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"EmployeeDetails");
        }

        public int CalculateYearsOfService()
        { 
            TimeSpan duration = DateTime.Now - HireDate;
            return (int)duration.TotalDays / 365;
        }
    }
}
