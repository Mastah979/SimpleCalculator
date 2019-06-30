using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            //Setting up the data
            int number1 = 1;
            int number2 = 2;
            //Processing data
            double result = _calculatorEngine.Calculate(number1, number2, "add");
            //Comparision
            Assert.AreEqual(3, result);
            
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            //Setting up the data
            int number1 = 1;
            int number2 = 2;
            //Processing data
            double result = _calculatorEngine.Calculate(number1, number2, "+");
            //Comparision
            Assert.AreEqual(3, result);

        }
    }
}
