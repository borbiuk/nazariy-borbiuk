using System;
using System.Collections.Generic;
using LogicApplication.Company;
using LogicApplication.Company.Employees;

namespace LogicApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new department
            Department department = new Department();

            // create new managers
            Manager manager0 = new Manager("Man0", "Man0s", 2000, 10);
            Manager manager1 = new Manager("Man1", "Man1s", 1000, 3);

            // add managers to department
            department.AddManager(manager0);
            department.AddManager(manager1);

            // create new developers
            Developer developer0 = new Developer("Dev0", "Dev0s", 100, 1);
            Developer developer1 = new Developer("Dev1", "Dev1s", 100, 3);
            Developer developer2 = new Developer("Dev2", "Dev2s", 100, 11);

            // create new designers
            Designer designer0 = new Designer("Des0", "Des0s", 100, 1, 1);
            Designer designer1 = new Designer("Des1", "Des1s", 100, 3, 0.5m);
            Designer designer2 = new Designer("Des2", "Des2s", 100, 11, 0.1m);

            // add emplotees to managers
            manager0.AddToTeam(designer0);
            manager0.AddToTeam(developer0);
            manager0.AddToTeam(developer1);

            manager1.AddToTeam(designer1);
            manager1.AddToTeam(designer2);
            manager1.AddToTeam(developer2);
            

            // give salary
            List<string> salaryInfo = department.GiveSalary();

            // display result
            foreach(var item in salaryInfo)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
