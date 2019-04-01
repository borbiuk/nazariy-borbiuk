namespace LogicApplication.Company.Employees
{
    public abstract class Employee
    {
        // properties that have each employee
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public decimal Salary { get; set; }
        public int Experience { get; set; }
        public Manager Manager { get; set; }

        // base constructor for employee
        protected Employee(string firstName, string secondName, decimal salary, int experience, Manager manager)
        {
            FirstName = firstName;
            SecondName = secondName;
            Salary = salary;
            Experience = experience;
            Manager = manager;
        }

        // employee representation
        public override string ToString()
        {
            return string.Format("{0} {1}, manager: {2}, experience: {3}", 
                    FirstName,
                    SecondName,
                    Manager?.SecondName,
                    Experience);
        }
    }
}
