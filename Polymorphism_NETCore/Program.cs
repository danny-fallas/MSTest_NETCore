using System;
using System.Collections.Generic;
using Moq;

namespace Polymorphism_NETCore
{
    public class Employee
    {
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            /*string result = string.Format(@"\nThis ANGRY EMPLOYEE worked {0} hrs.
                              Paid for 40 hrs at $ {1}
                              /hr = ${2} \n", weeklyHours, wage, salary);
            Refactor: use string interpolation */

            string result = $"This ANGRY EMPLOYEE worked {weeklyHours} hrs." +
                              $"Paid for 40 hrs at $ {wage}" +
                              $"/hr = ${salary}";


            return result;
        }
    }

    public class Contractor : Employee
    {
        public override string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            /*string result = string.Format(@"\nThis HAPPY CONTRACTOR worked {0} hrs.
                              Paid for {0} hrs at $ {1}
                              /hr = ${2} ", weeklyHours, wage, salary);
            Refactor: use string interpolation */

            string result = $"This HAPPY CONTRACTOR worked {weeklyHours} hrs" +
                              $"Paid for {weeklyHours} hrs at $ {wage}" +
                              $"/hr = ${salary}";

            return result;
        }
    }


    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 55, wage = 70;
            //List<Employee> employees = Utils.GetEmployees();
            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetMockEmployees())
            .Returns(() => new List<Employee> { new Contractor(), new Employee() });

            List<Employee> employees = mock.Object.GetMockEmployees();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }

        /*Refactor: there are two roles, get to a separate class
        private static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            var everyone = new List<Employee> { someEmployee, someContractor };
            return everyone;
        }*/
    }

    //Refactor: apply single responsability
    public class Utils
    {
        /* We will Mock this object
        public static List<Employee> GetEmployees()
        {
            var someEmployee = new Employee();
            var someContractor = new Contractor();
            var everyone = new List<Employee> { someEmployee, someContractor };
            return everyone;
        }*/

        public virtual List<Employee> GetMockEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
