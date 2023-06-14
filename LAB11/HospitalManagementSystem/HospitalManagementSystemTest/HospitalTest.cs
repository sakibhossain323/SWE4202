using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HospitalManagementSystem;
using System.Collections.Generic;

namespace HospitalManagementSystemTest
{
    [TestClass]
    public class HospitalTest
    {
        [TestMethod]
        public void SearchByJoiningYearTest()
        {
            //  Arrange
            List<Employee> testData = GetEmployeeTestData();
            List<Employee> expected = new List<Employee> { testData[0], testData[3], testData[5] };
            
            Hospital hospital = new Hospital();
            foreach (Employee emp in testData) hospital.AddEmployee(emp);


            //  Act
            List<Employee> actual = hospital.SearchByJoiningYear(2020);


            //  Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void SearchByDepartmentTest()
        {
            //  Arrange
            List<Employee> testData = GetEmployeeTestData();
            List<Employee> expected = new List<Employee> { testData[1], testData[3] };

            Hospital hospital = new Hospital();
            foreach (Employee emp in testData) hospital.AddEmployee(emp);


            //  Act
            List<Employee> actual = hospital.SearchByDepartment("Cardiology");


            //  Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }

        // Method to generate test data for employees
        private List<Employee> GetEmployeeTestData()
        {
            List<Employee> employees = new List<Employee>
            {
                new Doctor("John", "AddressX", "999-123", "john@hsp.com", new DateTime(2020, 12, 10), "Neurology", "Head of Department"),
                new Doctor("Jane", "AddressY", "999-456", "jane@hsp.com", new DateTime(2021, 3, 15), "Cardiology", "Senior Doctor"),
                new Nurse("Alice", "AddressZ", "999-321", "alice@hsp.com", new DateTime(2021, 10, 12), "Neurology", "Assisting Nurse"),
                new Nurse("Sarah", "AddressP", "999-654", "sarah@hsp.com", new DateTime(2020, 7, 15), "Cardiology", "Head Nurse"),
                new ManagementStuff("Smith", "AddressQ" , "999-789", "smith@hsp.com", new DateTime(2021, 5, 15), "Finance", "Director"),
                new ManagementStuff("Brown", "AddressR" , "999-987", "brown@hsp.com", new DateTime(2020, 3, 12), "Revenue", "Accountant"),
            };

            return employees;
        }
    }
}
