using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LogicApplication.Company.Employees;
using LogicApplication.Company.Tools;

namespace LogicApplication.Company
{
    public class Department
    {
        // list of managers
        protected List<Manager> _managers;

        // constructor
        public Department()
        {
            _managers = new List<Manager>();
        }

        // add manager for department
        public void AddManager(Manager manager)
        {
            if (_managers.Contains(manager))
            {
                throw new ArgumentException("This manager has already been added to the list");
            }

            _managers.Add(manager);
        }

        // give a salary to all employees
        /*
         * After changing ConcurentDictionary<> to Dictionary<> sometimes skipping one employee.
         * fixing in process ...
         */
        public List<string> GiveSalary()
        {
            List<string> report = new List<string>();

            Parallel.ForEach(_managers, manager =>
            {
                report.Add(GiveSalary(manager));
                Parallel.ForEach(manager.Team, member => 
                {
                    report.Add(GiveSalary(member));
                });
            });

            return report;
        }

        // give a salary to the employee
        private string GiveSalary(Employee employee)
        {
            ICalculator _calculator = CalculatorFactory.GetCalculator(employee);

            return string.Format("{0} {1}: got salary: {2:N0}", 
                    employee.FirstName, 
                    employee.SecondName, 
                    _calculator.CalculateSalary(employee));
        }
    }
}
