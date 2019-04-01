using System;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    public class DeveloperCalculator : EmployeeCalculator
    {
        // calculate salary with bonus for developer
        public override decimal CalculateSalary(Employee employee)
        {
            if (!(employee is Developer))
            {
                throw new ArgumentException("Emloyee must be developer");
            }

            return base.CalculateSalary((Developer)employee);
        }
    }
}
