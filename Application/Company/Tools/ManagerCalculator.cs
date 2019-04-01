using System;
using System.Collections.Generic;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    public class ManagerCalculator : EmployeeCalculator
    {
        // salary calculator for manager
        public override decimal CalculateSalary(Employee employee)
        {
            if (!(employee is Manager))
            {
                throw new ArgumentException("Emloyee must be manager");
            }

            decimal salaryWithBonus = base.CalculateSalary(employee);

            if (((Manager)employee).Team.Count > 10)
            {
                salaryWithBonus += 300;
            }
            else if (((Manager)employee).Team.Count > 5)
            {
                salaryWithBonus += 200;
            }
            if (IsBonusByTeamContain(((Manager)employee).Team))
            {
                salaryWithBonus *= 1.1m;
            }

            return salaryWithBonus;
        }

        // bonus by team condition
        private bool IsBonusByTeamContain(List<Employee> team)
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
