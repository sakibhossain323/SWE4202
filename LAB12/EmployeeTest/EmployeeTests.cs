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

        [TestMethod]
        public void SalesEmployeeCalculateSalaryIncrease()
        {
            var salesEmployee = new SalesEmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "Sales Associate",
                Salary = 100000m,
                SalesTarget = 10,
                SalesAchieved = 5
            };

            decimal expected = 102500.0m;
            Assert.AreEqual(salesEmployee.CalculateSalaryIncrease(), expected);
        }

        [TestMethod]
        public void EngineeringEmployeeSalaryIncreaseNO()
        {
            var engineeringEmployee = new EngineeringEmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "Junior Executive Engineer",
                Salary = 100000m,
                YearsOfExperience= 4
            };

            decimal expected = 100000m;
            Assert.AreEqual(expected, engineeringEmployee.CalculateSalaryIncrease());
        }

        [TestMethod]
        public void EngineeringEmployeeSalaryIncreaseYES()
        {
            var engineeringEmployee = new EngineeringEmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "Senior Executive Engineer",
                Salary = 100000m,
                YearsOfExperience = 5
            };

            decimal expected = 105000m;
            Assert.AreEqual(expected, engineeringEmployee.CalculateSalaryIncrease());
        }
        
        [TestMethod]
        public void PerformPerformanceReviewIneligible()
        {
            var marketingEmployee = new MarketingEmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "Junior Marketer",
                Salary = 100000m,
                MarketingCampaigns = 2
            };


            Assert.ThrowsException<IneligibleForSalaryIncreaseException>(() => marketingEmployee.PerformPerformanceReview());
        }

        [TestMethod]
        public void PerformPerformanceReviewEligible()
        {
            var marketingEmployee = new MarketingEmployee
            {
                Name = "Alice Johnson",
                EmployeeID = 1,
                JobTitle = "Senior Marketer",
                Salary = 100000m,
                MarketingCampaigns = 3
            };


            try { marketingEmployee.PerformPerformanceReview(); }
            catch (Exception e) { Assert.Fail("Expected no exception, but got: " + e.Message); }
        }
    }
}
