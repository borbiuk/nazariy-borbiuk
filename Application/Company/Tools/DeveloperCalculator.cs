using System;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    public class DeveloperCalculator : EmployeeCalculator
    {
        // calculate salary with bonus for developer
        public override decimal CalculateSalary(Employee developer)
        {
            return base.CalculateSalary(developer);
        }
    }
}
