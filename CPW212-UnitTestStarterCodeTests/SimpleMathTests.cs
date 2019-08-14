using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double expectedSum = num1 + num2;

            // assert with act
            Assert.AreEqual( expectedSum, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Use a few pairs of values to test the Multiply method
            double posTimesNeg = -10.00;
            double negTimesNeg = 4;
            double timesZero = 0;

            // assert
            Assert.AreEqual( posTimesNeg, SimpleMath.Multiply(5, -2) );
            Assert.AreEqual(negTimesNeg, SimpleMath.Multiply(-2, -2));
            Assert.AreEqual(timesZero, SimpleMath.Multiply(-2, 0));

        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            double zero = 0;
            double nonZero = -5;
            Assert.ThrowsException<ArgumentException>(() =>
                SimpleMath.Divide(nonZero, zero));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(1, 5)]
        [DataRow(-1, 5)]
        [DataRow(-1, -5)]
        public void Divide_TwoValidNumbers_ReturnsProduct(double num1, double num2)
        {
            // arrange
            double expectedProduct = num1 / num2;

            // assert/act
            Assert.AreEqual(expectedProduct, SimpleMath.Divide(num1, num2));

        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(-1, -1)]
        [DataRow(0, 1)]
        [DataRow(2, 1)]
        public void Subtract_TwoValidNumbers_ReturnsSum(double num1, double num2)
        {
            // arrange
            double expectedProduct = num1 - num2;

            // assert/act
            Assert.AreEqual(expectedProduct, SimpleMath.Subtract(num1, num2));
        }
    }
}