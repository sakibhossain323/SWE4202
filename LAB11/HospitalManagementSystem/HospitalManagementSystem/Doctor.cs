﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Doctor: Employee
    {
        public List<string> Degrees { get; set; } = new List<string>();
        public List<Doctor> Colleagues { get; set; } = new List<Doctor>();

        public Doctor(string name, string address, string phoneNum, string email, DateTime hireDate, string dept, string pos): base(name, address, phoneNum, email, hireDate)
        {
            Department= dept;
            Position= pos;
        }
    }
}
