using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        readonly List<Employee> _employees = new List<Employee>();
        
        public Hospital() { }

        public void AddEmployee(Employee employee) { _employees.Add(employee); }
        public void RemoveEmployee(Employee employee) { _employees.Remove(employee); }

        public List<Employee> ListEmployees() { return _employees; }

        public List<Employee> SearchByName(string name)
        {
            List <Employee> matchlist = new List<Employee>();
            foreach(Employee emp in _employees)
            {
                if(emp.Name.Contains(name)) matchlist.Add(emp);
            }

            return matchlist;
        }

        public List<Employee> SearchByJoiningYear(int year)
        {
            List<Employee> matchlist = new List<Employee>();
            foreach (Employee emp in _employees)
            {
                if (emp.HireDate.Year == year) matchlist.Add(emp);
            }

            return matchlist;
        }

        public List<Employee> SearchByPosition(string pos)
        {
            List<Employee> matchlist = new List<Employee>();
            foreach (Employee emp in _employees)
            {
                if (emp.Position.Contains(pos)) matchlist.Add(emp);
            }

            return matchlist;
        }

        public List<Employee> SearchByDepartment(string dept)
        {
            List<Employee> matchlist = new List<Employee>();
            foreach (Employee emp in _employees)
            {
                if (emp.Department.Contains(dept)) matchlist.Add(emp);
            }

            return matchlist;
        }
    }
}
