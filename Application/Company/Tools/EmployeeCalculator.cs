using System;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    /// <summary>
    /// provides basic calculations for eployees
    /// </summary>
    public abstract class EmployeeCalculator : ICalculator
    {
        // salary calculation by experience for employee
        public virtual decimal CalculateSalary(Employee employee)
        {
            decimal salaryWithBonus = employee.Salary;

            if (employee.Experience > 5)
            {
                salaryWithBonus *= 1.2m;
                salaryWithBonus += 500;
            }
            else if (employee.Experience > 2)
            {
                salaryWithBonus += 200;
            }

            return salaryWithBonus;
        }
    }
}
