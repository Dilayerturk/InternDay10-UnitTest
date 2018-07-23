using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void PlusTest()
        {
            PlusAssert(5, 5.27, 10.27);
            PlusAssert(-4, 7, 3);
        }

        [TestMethod()]
        public void SubsTest()
        {
            SubsAssert(5, 5, 0);
            SubsAssert(-4, 7, -11);
        }

        [TestMethod()]
        public void DivideTest()
        {
            DivideAssert(5, 5, 1);
            DivideAssert(14, 7, 2);
        }

        [TestMethod()]
        public void MultpTest()
        {
            MultpAssert(5, 5, 25);
            MultpAssert(4, 6, 24);
        }

        private void PlusAssert(double a, double b, double expectedResult)
        {
            expectedResult = a + b;

            Calculator calculator = new Calculator();
            double actualResult = calculator.Plus(a, b);

            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}", expectedResult, a, b, actualResult);
        }

        private void SubsAssert(double a, double b, double expectedResult)
        {
            expectedResult = a - b;

            Calculator calculator = new Calculator();
            double actualResult = calculator.Subs(a, b);

            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}", expectedResult, a, b, actualResult);
        }

        private void MultpAssert(double a, double b, double expectedResult)
        {
            expectedResult = a * b;

            Calculator calculator = new Calculator();
            double actualResult = calculator.Multp(a, b);

            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}", expectedResult, a, b, actualResult);
        }

        private void DivideAssert(double a, double b, double expectedResult)
        {
            expectedResult = a / b;

            Calculator calculator = new Calculator();
            double actualResult = calculator.Divide(a, b);

            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}", expectedResult, a, b, actualResult);
        }

       
    }
}