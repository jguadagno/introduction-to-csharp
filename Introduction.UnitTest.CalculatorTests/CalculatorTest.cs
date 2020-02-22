using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Introduction.UnitTest.CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Addition_AddingTwoNumbers_Test()
        {
            // Arrange
            var calculator = new Calculator.Calculator();
            var additive1 = 1;
            var additive2 = 2;

            // Act
            var actualResult = calculator.Add(additive1, additive2);

            // Assert
            var expectResult = additive1 + additive2;
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void Addition_AddingOneNumbers_Test()
        {
            // Arrange
            var calculator = new Calculator.Calculator();
            var additive1 = 1;

            // Act
            var actualResult = calculator.Add(additive1);

            // Assert
            var expectResult = additive1;
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void Subtraction_SubtractingTwoNumbers_Test()
        {
            // Arrange
            var calculator = new Calculator.Calculator();
            var negative1 = 3;
            var negative2 = 2;

            // Act
            var actualResult = calculator.Subtract(negative1, negative2);

            // Assert
            var expectResult = negative1 - negative2;
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Divide_TestForDivideByZero_Test()
        {
            // Arrange
            var calculator = new Calculator.Calculator();
            var dividend = 1;
            var divisor = 0;

            // Act
            var actualResult = calculator.Divide(dividend, divisor);

            // Assert
            Assert.IsTrue(true);

        }
        [TestMethod]
        public void Divide_TestForDivideByZeroTestMessage_Test()
        {
            // Arrange
            var calculator = new Calculator.Calculator();
            var dividend = 1;
            var divisor = 0;

            // Act
            try
            {
                var actualResult = calculator.Divide(dividend, divisor);
            }
            catch (Exception exception)
            {
                if (exception.Message == "We can not divide by zero")
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsFalse(true, "Messages did not match");
                }

            }
            // Assert


        }
    }
}
