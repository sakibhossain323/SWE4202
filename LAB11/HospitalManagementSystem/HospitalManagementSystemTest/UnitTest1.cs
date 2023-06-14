using HospitalManagementSystem;

namespace HospitalManagementSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateYearsOfServiceTest()
        {
            //intialize
            Hospital tHospital = new Hospital();
            Doctor tDoc1 = new Doctor("Alfe Sani", "BoardBazar", "999", "alfe@gmail.com", new DateTime(2020, 5, 10), "Neurology", "Junior Doctor");
            tHospital.AddEmployee(tDoc1);

            int expected = 3;

            //Assert

        }
    }
}