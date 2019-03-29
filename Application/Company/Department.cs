using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using LogicApplication.Company.Employees;
using LogicApplication.Company.Tools;

namespace LogicApplication.Company
{
    public class Department
    {
        // pairs of employee type and calculator
        private static ConcurrentDictionary<Type, ICalculator> _employeeToCalculator;
        private ICalculator _calculator;

        // list of managers
        public List<Manager> Managers { get; private set; }

        // static constructor
        static Department()
        {
            _employeeToCalculator = new ConcurrentDictionary<Type, ICalculator>();
        }

        // constructor
        public Department()
        {
            Managers = new List<Manager>();
        }

        // add manager for department
        public void AddManager(Manager manager)
        {
            if (!Managers.Contains(manager))
                Managers.Add(manager);
        }

        // add manager for department
        public void AddManager(Manager[] managers)
        {
            Parallel.ForEach(managers, manager =>
            {
                if (!Managers.Contains(manager))
                {
                    Managers.Add(manager);
                }
            });
        }

        // give a salary to all employees
        public List<string> GiveSalary()
        {
            List<string> info = new List<string>();

            Parallel.ForEach(Managers, manager =>
            {
                info.Add(GiveSalary(manager));
                Parallel.ForEach(manager.Team, member => 
                {
                    info.Add(GiveSalary(member));
                });
            });

            return info;
        }

        // give a salary to the employee
        public string GiveSalary(Employee employee)
        {
            // if there is no calculator for an employee, then will create it
            if (!_employeeToCalculator.ContainsKey(employee.GetType()))
            {
                _employeeToCalculator.TryAdd(
                    employee.GetType(), 
                    CalculatorFactory.CreateCalculator(employee)
                    );
            }

            // set calculator by employee type
            _calculator = _employeeToCalculator[employee.GetType()];

            return string.Format("{0} {1}: got salary: {2:N0}", 
                    employee.FirstName, 
                    employee.SecondName, 
                    _calculator.CalculateSalary(employee));
        }
    }
}
