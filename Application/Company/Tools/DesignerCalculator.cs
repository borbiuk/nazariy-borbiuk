using System;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    public class DesignerCalculator : EmployeeCalculator
    {
        // calculate salary with bonus for designer
        public override decimal CalculateSalary(Employee employee)
        {
            if (!(employee is Designer))
            {
                throw new ArgumentException("Emloyee must be designer");
            }

            return base.CalculateSalary(employee) * ((Designer)employee).Effectiveness;
        }
    }
}
