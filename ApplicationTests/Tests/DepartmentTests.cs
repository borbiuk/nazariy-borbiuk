using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicApplication.Company;
using LogicTests.Mockys;

namespace LogicTests.Tests
{
    /// <summary>
    /// Test Class that covering unit tests Department class
    /// </summary>
    [TestClass]
    public class DepartmentTests
    {
        [TestMethod]
        public void EmptyDepartmentIsNotNullDepartment()
        {
            // Arrange
            Department department;

            // Act
            department = new Department();

            // Assert
            Assert.IsNotNull(department);
        }

        [TestMethod]
        public void EmptyDepartmentHaveEmptyManagersList()
        {
            // Arrange
            Department department = new Department();

            // Act
            var managers = department.Managers;

            // Assert
            Assert.IsTrue(managers.Count == 0);
        }

        [TestMethod]
        public void AddManagerMethodAddManagerToDepartmentList()
        {
            // Arrange
            Department department = new Department();
            FakeManager fake1 = new FakeManager();

            // Act
            department.AddManager(fake1);

            // Assert
            Assert.IsTrue(department.Managers.Contains(fake1));
        }

        [TestMethod]
        public void AddManagerMethodDontAddSameManagerToDepartmentList()
        {
            // Arrange
            Department department = new Department();
            FakeManager fake1 = new FakeManager();

            // Act
            department.AddManager(fake1);
            department.AddManager(fake1);

            // Assert
            Assert.IsTrue(department.Managers.Count == 1);
        }
    }
}
