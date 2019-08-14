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
            Assert.AreEqual( negTimesNeg, SimpleMath.Multiply(-2, -2) );
            Assert.AreEqual( timesZero, SimpleMath.Multiply(-2, 0) );

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
        public void Divide_TwoValidNumbers_ReturnsProduct()
        {
            double validNumber1 = 2;
            double validNumber2 = 5;

            Assert.AreEqual();
        }
       
      

        // TODO: Test subtract method with two valid numbers
    }
}