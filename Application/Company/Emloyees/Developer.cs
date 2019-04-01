namespace LogicApplication.Company.Employees
{
    public class Developer : Employee
    {
        public Developer(string firstName, string secondName, decimal salary, int experience)
                : base(firstName, secondName, salary, experience, null)
        { }
    }
}
