using System;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    public class DesignerCalculator : EmployeeCalculator
    {
        // calculate salary with bonus for designer
        public override decimal CalculateSalary(Employee designer)
        {
            return base.CalculateSalary(designer) * ((Designer)designer).Effectiveness;
        }
    }
}
