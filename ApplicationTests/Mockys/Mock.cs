using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicApplication.Company.Employees;

namespace LogicTests.Mockys
{
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
}
