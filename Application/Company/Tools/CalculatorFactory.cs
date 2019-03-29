using System;
using System.Collections.Generic;
using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    /// <summary>
    /// factory of calculators for employees
    /// </summary>
    public static class CalculatorFactory
    {
        private static readonly Dictionary<Type, int> typePairs = new Dictionary<Type, int>
        {
            {typeof(Employee), 0 },
            {typeof(Manager), 1 },
            {typeof(Developer), 2 },
            {typeof(Designer), 3 }
        };

        // create calculator by employee type
        public static ICalculator CreateCalculator(Employee employee)
        {
            switch(typePairs[employee.GetType()])
            {
                case 1:
                    return new ManagerCalculator();

                case 2:
                    return new DeveloperCalculator();

                case 3:
                    return new DesignerCalculator();

                default:
                    throw new ArgumentOutOfRangeException("Can't create Calcutator for this employee");
            }
        }
    }
}
