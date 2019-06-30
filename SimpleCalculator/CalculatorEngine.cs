using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public CalculatorEngine()
        {
        }

        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            double result;
            
            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "substract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }
            return result;
        }
    }
}