using System;

namespace lib_Calculator
{
    public class SalaryCalculator
    {

        /* Refactor phase: Improve the code. */
        const int HoursPerYear = 2080;

        /* Green phase: create all the objects and logit to make the test pass */
        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursPerYear;

        public decimal GetHourlyWage(int annualSalary) => annualSalary / HoursPerYear;
    }
}
