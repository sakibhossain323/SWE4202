using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class ManagementStuff : Employee
    {
        public ManagementStuff(string name, string address, string phoneNum, string email, DateTime hireDate, string dept, string pos) : base(name, address, phoneNum, email, hireDate)
        {
            Department = dept;
            Position = pos;
        }
    }
}
