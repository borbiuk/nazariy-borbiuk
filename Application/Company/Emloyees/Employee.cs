using System;

namespace LogicApplication.Company.Employees
{
    public abstract class Employee
    {
        protected string _firstName;
        protected string _secondName;
        protected decimal _salary;
        protected int _experience;
        protected Manager _manager;

        // properties that have each employee
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public decimal Salary { get => _salary; set => _salary = value; }
        public int Experience { get => _experience; set => _experience = value; }
        public Manager GetManager { get => _manager; }
        public Manager SetManager { set => _manager = value; }

        // base constructor for employee
        protected Employee(string firstName, string secondName, decimal salary, int experience, Manager manager)
        {
            _firstName = firstName;
            _secondName = secondName;
            _salary = salary;
            _experience = experience;
            _manager = manager;
        }

        // employee representation
        public override string ToString()
        {
            return string.Format("{0} {1}, manager: {2}, experience: {3}",
                    _firstName,
                    _secondName,
                    _manager?.SecondName,
                    _experience);
        }
    }
}
