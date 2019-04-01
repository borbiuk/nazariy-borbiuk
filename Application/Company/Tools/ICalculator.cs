using LogicApplication.Company.Employees;

namespace LogicApplication.Company.Tools
{
    /// <summary>
    /// Provides calculation of some values for employees
    /// </summary>
    public interface ICalculator
    {
        decimal CalculateSalary(Employee employee);
    }
}
