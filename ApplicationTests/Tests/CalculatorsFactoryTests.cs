using System;
using LogicApplication.Company.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicTests.Mockys;

namespace ApplicationTests.Tests
{
    [TestClass]
    public class CalculatorsFactoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateCalculatorForNotValidEmployee()
        {
            // Arrange
            FakeEmployee fake = new FakeEmployee();
            ICalculator calculator;

            // Act
            calculator = CalculatorFactory.GetCalculator(fake);

            // Assert
        }
    }
}
