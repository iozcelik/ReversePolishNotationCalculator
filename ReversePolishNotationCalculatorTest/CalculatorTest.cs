using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversePolishNotationCalculator;

namespace ReversePolishNotationCalculatorTest {
    [TestClass]
    public class CalculatorTest {
        [TestMethod]
        public void Divide_4() {
            var result = Calculator.Calculate("20", "5", "/");
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void AdditionSubstraction_3() {
            var result = Calculator.Calculate("4", "2", "+", "3", "-");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void ComplexCalculation_141() {
            var result = Calculator.Calculate("3", "5", "8", "*", "7", "+", "*");
            Assert.AreEqual(141, result);
        }
    }
}
