using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EmployeeManagement;

namespace EmployeeTest
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestViewSalary_HRAuthorized()
        {
            var hrEmployee = new HREmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "HR Manager",
                Salary = 100000m,
                HRJobTitle = "Senior HR Manager"
            };

            var financeEmployee = new FinanceEmployee
            {
                Name = "Bob Smith",
                EmployeeID = 2,
                JobTitle = "Finance Manager",
                Salary = 75000m,
                FinanceJobTitle = "Senior Financial Analyst"
            };

            // Call ViewSalary method on HR employee with finance employee as parameter
            Assert.ThrowsException<AccessDeniedException>(() => hrEmployee.ViewSalary(financeEmployee));
        }

        [TestMethod]
        public void TestGetEmployeeInformation_HR()
        {
            var hrEmployee = new HREmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "HR Manager",
                Salary = 100000m,
                HRJobTitle = "Senior HR Manager"
            };

            // Check that GetEmployeeInformation method returns expected output
            Assert.AreEqual("Name: Alice Johnson, ID: 1, Job Title: HR Manager, Salary: $100,000.00, HR Job Title: Senior HR Manager", hrEmployee.GetEmployeeInformation());
        }
    }
}
