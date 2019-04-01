using System;
using System.Collections.Generic;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    /// <summary>
    /// Factory of employees calculators
    /// </summary>
    public static class CalculatorFactory
    {
        // pairs of employee type and calculator
        private static readonly Dictionary<Type, ICalculator> employeeToCalculator;

        // static initialization
        static CalculatorFactory()
        {
            employeeToCalculator = new Dictionary<Type, ICalculator>
            {
                { typeof(Manager), new ManagerCalculator() },
                { typeof(Developer), new DeveloperCalculator() },
                { typeof(Designer), new DesignerCalculator() }
            };
        }

        // return calculator by employee type
        public static ICalculator GetCalculator(Employee employee)
        {
            if (!employeeToCalculator.ContainsKey(employee.GetType()))
            {
                throw new ArgumentException("Factory not contains calculator for this employee");
            }

            return employeeToCalculator[employee.GetType()];
        }
    }
}