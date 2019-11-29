using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalcultorEngineUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1, b = 2, exp = 3;

            CalculatorEngine Calc = new CalculatorEngine();
            int actual = Calc.Addition(a,b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 1, b = 2, exp = -1;

            CalculatorEngine Calc = new CalculatorEngine();
            int actual = Calc.Soustraire(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 1, b = 2, exp = 2;

            CalculatorEngine Calc = new CalculatorEngine();
            int actual = Calc.Multiplier(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int a = 1, b = 1, exp = 1;

            CalculatorEngine Calc = new CalculatorEngine();
            int actual = Calc.Division (a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int a = 1, b = 0, exp = Int32.MinValue;

            CalculatorEngine Calc = new CalculatorEngine();
            int actual = Calc.Division(a, b);

            Assert.AreEqual(exp, actual);
        }

    }
}
