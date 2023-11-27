using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LabWindowsForms.Logic;

namespace LabWindowsFormsUnitTestProject
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void PerformCalculationAdditonTest()
        {
            // Arrange
            var obj = new Calc();
            // Act
            var result = obj.PerformCalculation(CalcType.Addition, 10, 20);
            // Assert
            Assert.AreEqual(30, result);
        }
        
        [TestMethod]
        public void PerformCalculationSubstrationTest()
        {
            // Arrange
            var obj = new Calc();
            // Act
            var result = obj.PerformCalculation(CalcType.Subtraction, 10, 20);
            // Assert
            Assert.AreEqual(-10, result);
        }
        
        [TestMethod]
        public void PerformCalculationMultiplyTest()
        {
            // Arrange
            var obj = new Calc();
            // Act
            var result = obj.PerformCalculation(CalcType.Multiplication, 4, 10);
            // Assert
            Assert.AreEqual(40, result);
        }
        
        [TestMethod]
        public void PerformCalculationDivideTest()
        {
            // Arrange
            var obj = new Calc();
            // Act
            var result = obj.PerformCalculation(CalcType.Division, 40, 10);
            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
