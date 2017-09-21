using lib_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
To get hourly, devide annual salary by 2080

To get annual, multiply hourly by 2060
 */
namespace MSTest_SalaryCalculator
{
    [TestClass]
    public class SalaryCalculatorTest
    {

        [TestMethod]
        public void AnnualSalaryTest()
        {
            /* Red phase: Create a test that most likely fail */

            //Arrange
            SalaryCalculator _calc = new SalaryCalculator();

            //Act
            decimal annualSalary = _calc.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            /* Red phase: Create a test that most likely fail */

            //Arrange
            SalaryCalculator _calc = new SalaryCalculator();

            //Act
            decimal hourlyWage = _calc.GetHourlyWage(52000);

            //Assert
            Assert.AreEqual(25, hourlyWage);
        }
    }
}
