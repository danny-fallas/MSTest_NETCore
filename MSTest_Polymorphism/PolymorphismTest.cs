using Polymorphism_NETCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_Polymorphism
{
    [TestClass]
    public class PolymorphismTest
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest()
        {
            //Arrange
            int weeklyHours = 55,
             wage = 70,
             salary = 40 * wage; //2800

             Employee _employee  = new Employee();

             string expectedResult = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs." +
                              $"Paid for 40 hrs at $ {wage}" +
                              $"/hr = ${salary}";
            //Act
            string response = _employee.CalculateWeeklySalary(weeklyHours, wage);
            
            //Assert
            Assert.AreEqual(response,expectedResult);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeFailTest()
        {
            //Arrange
            int weeklyHours = 55,
             wage = 70,
             salary = 40 * wage;

             Employee _employee  = new Employee();

             string expectedResult = $"FAIL: This ANGRY EMPLOYEE worked {weeklyHours} hrs." +
                              $"Paid for 40 hrs at $ {wage}" +
                              $"/hr = ${salary}";
            //Act
            string response = _employee.CalculateWeeklySalary(weeklyHours, wage);
            
            //Assert
            Assert.AreNotEqual(response,expectedResult);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest()
        {
            //Arrange
            int weeklyHours = 55,
             wage = 70,
             salary = weeklyHours * wage; //3850

             Contractor _employee  = new Contractor();

             string expectedResult = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs" +
                              $"Paid for {weeklyHours} hrs at $ {wage}" +
                              $"/hr = ${salary}";
            //Act
            string response = _employee.CalculateWeeklySalary(weeklyHours, wage);
            
            //Assert
            Assert.AreEqual(response,expectedResult);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorFailTest()
        {
            //Arrange
            int weeklyHours = 55,
             wage = 70,
             salary = weeklyHours * wage;

             Contractor _employee  = new Contractor();

             string expectedResult = $"FAIL: This HAPPY CONTRACTOR worked {weeklyHours} hrs" +
                              $"Paid for {weeklyHours} hrs at $ {wage}" +
                              $"/hr = ${salary}";
            //Act
            string response = _employee.CalculateWeeklySalary(weeklyHours, wage);
            
            //Assert
            Assert.AreNotEqual(response,expectedResult);
        }
    }
}
