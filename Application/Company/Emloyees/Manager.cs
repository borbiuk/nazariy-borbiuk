using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicApplication.Company.Employees
{
    public class Manager : Employee
    {
        // a list of employees guided by the manager
        public List<Employee> Team { get; protected set; }

        // constructor
        public Manager(string firstName, string secondName, decimal salary, int experience)
                : base(firstName, secondName, salary, experience, null)
        {
            Team = new List<Employee>();
        }

        // add employee to manager team
        public void AddToTeam(Employee employee)
        {
            if (employee is Manager)
            {
                throw new ArgumentOutOfRangeException("You can't add manager to team");
            }
            if (Team.Contains(employee))
            {
                throw new ArgumentException("This employee has already been added to the team");
            }

            employee.SetManager = this;
            Team.Add(employee);
        }

        // add employees to manager team
        public void AddToTeam(Employee[] employees)
        {
            Parallel.ForEach(employees, employee =>
            {
                AddToTeam(employee);
            });
        }
    }
}
