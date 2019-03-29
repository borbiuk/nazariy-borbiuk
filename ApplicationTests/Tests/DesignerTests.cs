using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicApplication.Company.Employees;
using LogicTests.Mockys;

namespace LogicTests.Tests
{
    /// <summary>
    /// Test Class that covering unit tests Designer class
    /// </summary>
    [TestClass()]
    public class DesignerTests
    {
        [TestMethod()]
        public void DesignerToStringWithoutManagerTest()
        {
            // Arrange
            Designer designer = new Designer("name", "second_name", 100, 1, 1);
            string expected = "name second_name, manager: , experience: 1";

            // Act
            string actual = designer.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DesignerToStringWithManagerTest()
        {
            // Arrange
            string expected = "name second_name, manager: secondName, experience: 1";

            Designer designer = new Designer("name", "second_name", 100, 1, 1);
            Manager manager = new FakeManager();

            // Act
            manager.AddToTeam(designer);
            string actual = designer.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
