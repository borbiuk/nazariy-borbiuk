using System;
using System.Collections.Generic;

namespace LogicApplication.Company.Employees
{
    public class Manager : Employee
    {
        // a list of employees guided by the manager
        /*
         * Not private, because we call to this property from calculator and department
         * to get count, team members, etc.
         */
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
            if (!(employee is Developer || employee is Designer))
            {
                throw new ArgumentOutOfRangeException(
                        "To add an employee to the team, he must be a developer or designer");
            }
            if (Team.Contains(employee))
            {
                throw new ArgumentException("This employee has already been added to the team");
            }

            employee.Manager = this;
            Team.Add(employee);
        }
    }
}
