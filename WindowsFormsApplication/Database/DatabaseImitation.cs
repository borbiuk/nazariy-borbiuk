using System.Collections.Generic;
using LogicApplication.Company.Employees;

namespace WindowsFormsApplication.Database
{
    public class DatabaseImitation
    {
        private static List<Employee> EmployeeList { get; set; }

        static DatabaseImitation()
        {
            EmployeeList = new List<Employee>();
        }

        public static bool Contains(Employee employee)
        {
            foreach (var member in EmployeeList)
            {
                if (employee.FirstName == member.FirstName
                    && employee.SecondName == member.SecondName)
                {
                    return false;
                }
            }

            return true;
        }

        // Add items
        public static void AddEmployee(Manager manager) { EmployeeList.Add(manager); }
        public static void AddEmployee(Developer developer) { EmployeeList.Add(developer); }
        public static void AddEmployee(Designer designer) { EmployeeList.Add(designer); }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (Employee item in EmployeeList)
            {
                result += item.ToString();
                result += "\n";
            }

            return result;
        }
    }
}
