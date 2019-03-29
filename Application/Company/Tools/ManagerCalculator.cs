using System;
using System.Collections.Generic;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    public class ManagerCalculator : EmployeeCalculator
    {
        // salary calculator for manager
        public override decimal CalculateSalary(Employee manager)
        {
            decimal salaryWithBonus = base.CalculateSalary(manager);

            if (((Manager)manager).Team.Count > 10)
            {
                salaryWithBonus += 300;
            }
            else if (((Manager)manager).Team.Count > 5)
            {
                salaryWithBonus += 200;
            }
            if (IsBonus(((Manager)manager).Team))
            {
                salaryWithBonus *= 1.1m;
            }

            return salaryWithBonus;
        }

        // bonus by team condition
        private bool IsBonus(List<Employee> team)
        {
            int diff = 0;
            foreach (var employee in team)
            {
                if (employee is Developer)
                {
                    diff++;
                }
                else if (employee is Designer)
                {
                    diff--;
                }
            }

            return (diff > 0);
        }
    }
}
