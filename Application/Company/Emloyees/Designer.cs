using System;

namespace LogicApplication.Company.Employees
{
    public class Designer : Employee
    {
        private decimal _effectiveness;

        public decimal Effectiveness
        {
            get => _effectiveness;
            set
            {
                if (value >= 0 && value <= 1)
                {
                    _effectiveness = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The value should be between 0 and 1");
                }
            }
        }

        public Designer(string firstName, string secondName, decimal salary, int experience, decimal effectiveness)
                : base(firstName, secondName, salary, experience, null)
        {
            Effectiveness = effectiveness;
        }
    }
}
