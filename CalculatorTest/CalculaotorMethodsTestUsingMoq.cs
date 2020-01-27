using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;

namespace CalculatorTest
{
    [TestClass]
    public class CalculaotorMethodsTestUsingMoq
    {

        [TestMethod]
        public void AddSimpleTestMoq()
        {
            var mock = new Mock<Calculator.ICalculatorMethods>();
            mock.Setup(x => x.add(29, 2)).Returns(31);
            mock.Setup(x => x.add(9, -1)).Returns(8);

        }

        [TestMethod]
        public void divideByZeroMoq()
        {
            var mock = new Mock<Calculator.ICalculatorMethods>();
            mock.Setup(cal => cal.divide(1, 0)).Throws<DivideByZeroException>();
        }

        [TestMethod]
        public void subtractArgumentCheckMoq()
        {
            var mock = new Mock<Calculator.ICalculatorMethods>();
            mock.Setup(cal => cal.subtract(It.IsAny<Int32>(),It.IsAny<Int32>())).Returns(1);
        }


    }
}
