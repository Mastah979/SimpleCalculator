using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Please input the first number");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Please input the second number");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Please specify the operation: add(+), substract(-), multiply(*), divide(/).");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(firstNumber, secondNumber, operation);

                Console.WriteLine("The result is: " + result);
            }
            catch (Exception ex)
            {
                //In real world we would want to log this msg
                //TODO: start logging exceptions
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
