using CSharpSupportEngineer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharpSupportEngineer.Testing
{
    [TestClass]
    public class CalculatorTesting
    {
        private Calculator calculator;
        public CalculatorTesting()
        {
            calculator = Factory.CreateCalculator(new MockupOutput());
        }

        [TestMethod]
        public void TestMultiply()
        {
            List<Tuple<decimal, decimal, decimal>> valuesForTesting = new List<Tuple<decimal, decimal, decimal>>()
            {
                new Tuple<decimal, decimal, decimal>(1, 1, 1),
                new Tuple<decimal, decimal, decimal>(1, 0, 0),
                new Tuple<decimal, decimal, decimal>(2.15m, 4.20m, 9.03m),
                new Tuple<decimal, decimal, decimal>(0, 1, 0)
            };

            foreach (var valueForTesting in valuesForTesting)
            {
                var expectedResult = valueForTesting.Item3;
                var actualResult = calculator.Multiply(valueForTesting.Item1, valueForTesting.Item2);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        [TestMethod]
        public void TestSumFromPlainText()
        {
            List<Tuple<string, decimal>> valuesForTesting = new List<Tuple<string, decimal>>()
            {
                new Tuple<string, decimal>("We sum the following number: 4.75 then 5 and 7 and finally 10.", 26.75m),
                new Tuple<string, decimal>("We sum the following number: 1 then 1 and 1 and finally 1.", 4),
                new Tuple<string, decimal>("We sum the following number: 0 then 2 and 7 and finally 10.5.", 19.5m),
                new Tuple<string, decimal>("We sum the following number: 0 then 0 and 0 and finally 0.", 0)
            };

            foreach (var valueForTesting in valuesForTesting)
            {
                var expectedResult = valueForTesting.Item2;
                var actualResult = calculator.SumFromPlainText(valueForTesting.Item1);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }


        [TestMethod]
        public void TestSumEvenNumbersFromStack()
        {
            List<Tuple<decimal[], decimal>> valuesForTesting = new List<Tuple<decimal[], decimal>>()
            {
                new Tuple<decimal[], decimal>(new[] {5m, 6m, 12m, 15m}, 18),
                new Tuple<decimal[], decimal>(new[] {5m, 7m, 9m, 11m}, 0),
                new Tuple<decimal[], decimal>(new[] {2m, 4m, 6m, 8m}, 20),
                new Tuple<decimal[], decimal>(new[] {0m, 6.5m, 12.5m, 15m}, 0)
            };

            foreach (var valueForTesting in valuesForTesting)
            {
                var expectedResult = valueForTesting.Item2;
                var actualResult = calculator.SumEvenNumbersFromStack(valueForTesting.Item1);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }


        [TestMethod]
        public void TestSumNumbers()
        {
            List<Tuple<List<Number>, decimal>> valuesForTesting = new List<Tuple<List<Number>, decimal>>()
            {
                new Tuple<List<Number>, decimal>(new List<Number>() {new Number(79), new Number(12), new Number(154), new Number(56)}, 301),
                new Tuple<List<Number>, decimal>(new List<Number>() {new Number(0), new Number(1.75m), new Number(5)}, 6.75m)
            };

            foreach (var valueForTesting in valuesForTesting)
            {
                var expectedResult = valueForTesting.Item2;
                var actualResult = calculator.SumNumbers(valueForTesting.Item1);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }


    }
}
