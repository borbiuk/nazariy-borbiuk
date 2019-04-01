using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicApplication.Company;
using LogicApplication.Company.Employees;
using LogicTests.Mockys;
using System;
using System.Collections.Generic;

namespace LogicTests.Tests
{
    /// <summary>
    /// Test Class that covering unit tests Department class
    /// </summary>
    [TestClass]
    public class DepartmentTests
    {
        [TestMethod]
        public void AddManagerMethodAddManagerToDepartmentList()
        {
            // Arrange
            FakeDepartment department = new FakeDepartment();
            FakeManager fake1 = new FakeManager();

            // Act
            department.AddManager(fake1);

            // Assert
            Assert.IsTrue(department.GetManagers.Contains(fake1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddManagerMethodDontAddSameManagerToDepartmentList()
        {
            // Arrange
            FakeDepartment department = new FakeDepartment();
            FakeManager fake1 = new FakeManager();

            // Act
            department.AddManager(fake1);
            department.AddManager(fake1);

            // Assert
        }

        [TestMethod]
        public void GiveSalaryEmptyDepartment()
        {
            // Arrange
            Department department = new Department();

            // Act
            List<string> reports = department.GiveSalary();

            // Assert
            Assert.IsTrue(reports.Count == 0);
        }

        [TestMethod]
        public void GiveSalaryDepartmentWithManagersOnly()
        {
            // Arrange
            Department department = new Department();
            Manager manager1 = new Manager("firstName1", "secondName1", 100, 1);
            Manager manager2 = new Manager("firstName2", "secondName2", 200, 2);
            department.AddManager(manager1);
            department.AddManager(manager2);

            // Act
            string expectedReports1 = "firstName1 secondName1: got salary: 100";
            string expectedReports2 = "firstName2 secondName2: got salary: 200";
            List<string> actualReports = department.GiveSalary();

            // Assert
            Assert.IsTrue(actualReports.Contains(expectedReports1) && actualReports.Contains(expectedReports2));
        }

        [TestMethod]
        public void GiveSalaryManagersAndTeamMembers()
        {
            // Arrange
            Department department = new Department();
            Manager manager1 = new Manager("firstName1", "secondName1", 100, 1);
            Manager manager2 = new Manager("firstName2", "secondName2", 200, 2);
            Developer developer1 = new Developer("firstName3", "secondName3", 300, 1);
            Developer developer2 = new Developer("firstName4", "secondName4", 400, 2);
            Designer designer1 = new Designer("firstName5", "secondName5", 500, 1, 1);
            Designer designer2 = new Designer("firstName6", "secondName6", 600, 2, 0.5m);

            department.AddManager(manager1);
            department.AddManager(manager2);
            manager1.AddToTeam(developer1);
            manager1.AddToTeam(designer1);
            manager2.AddToTeam(developer2);
            manager2.AddToTeam(designer2);

            // Act
            string expectedReports1 = "firstName1 secondName1: got salary: 100";
            string expectedReports2 = "firstName2 secondName2: got salary: 200";
            string expectedReports3 = "firstName3 secondName3: got salary: 300";
            string expectedReports4 = "firstName4 secondName4: got salary: 400";
            string expectedReports5 = "firstName5 secondName5: got salary: 500";
            string expectedReports6 = "firstName6 secondName6: got salary: 300";
            List<string> actualReports = department.GiveSalary();

            // Assert
            Assert.IsTrue(
                actualReports.Contains(expectedReports1)
                && actualReports.Contains(expectedReports2)
                && actualReports.Contains(expectedReports3)
                && actualReports.Contains(expectedReports4)
                && actualReports.Contains(expectedReports5)
                && actualReports.Contains(expectedReports6)
                );
        }
    }
}
