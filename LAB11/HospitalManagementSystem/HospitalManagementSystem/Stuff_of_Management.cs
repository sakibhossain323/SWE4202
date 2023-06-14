using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Stuff_of_Management: Employee
    {
        public Stuff_of_Management(string name, string address, string phoneNum, string email, DateTime hireDate, string dept, string pos) : base(name, address, phoneNum, email, hireDate)
        {
            this.Department = dept;
            this.Position = pos;
        }
    }
}
