using System.Collections.Generic;
using LogicApplication.Company.Employees;
using LogicApplication.Company;

namespace LogicTests.Mockys
{
    public class FakeDepartment : Department
    {
        public List<Manager> GetManagers { get => _managers; set => _managers = value; }
    }

    public class FakeManager : Manager
    {
        public FakeManager()
            : base("firstName", "secondName", 100, 1)
        {
        }
    }

    class FakeDeveloper : Developer
    {
        public FakeDeveloper()
            : base("firstName", "secondName", 100, 1)
        {
        }
    }

    class FakeDesigner : Designer
    {
        public FakeDesigner()
            : base("firstName", "secondName", 100, 1, 1)
        {
        }
    }

    class FakeEmployee : Employee
    {
        public FakeEmployee()
            : base("firstName", "secondName", 100, 1, null)
        {
        }
    }
}
