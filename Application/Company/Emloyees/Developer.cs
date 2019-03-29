using System;

namespace LogicApplication.Company.Employees
{
    public class Developer : Employee
    {
        // constructor
        public Developer(string firstName, string secondName, decimal salary, int experience)
                : base(firstName, secondName, salary, experience, null)
        { }
    }
}
