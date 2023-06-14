using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HospitalManagementSystem;

namespace HospitalManagementSystemTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void CalculateYearsOfServiceTest()
        {
            //  Arrange
            DateTime hired = new DateTime(2020, 5, 10);
            Doctor doc = new Doctor("Alfe Sani", "BoardBazar", "999", "alfe@gmail.com", hired, "Neurology", "Junior Doctor");
            int expected = (int)(DateTime.Now - hired).TotalDays / 365;


            //  Act
            int actual = doc.CalculateYearsOfService();


            //  Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
