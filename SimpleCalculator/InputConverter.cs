using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public InputConverter()
        {
        }

        public double ConvertInputToNumeric(string textInput)
        {
            //metoda dostepna od C# 7 (mozna w instrukcji warunkowej "?" zwrocic exception w razie niepowodzenia)
            return double.TryParse(textInput, out double convertedNumber) ? convertedNumber : throw new ArgumentException("Expected a numeric value.");


            
            //if (!double.TryParse(textInput, out double convertedNumber))
            //    throw new ArgumentException("Expected a numeric value.");
            //return convertedNumber;
            

        }
    }
}