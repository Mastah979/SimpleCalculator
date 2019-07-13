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
            
            if (!double.TryParse(textInput, out double convertedNumber))
                throw new ArgumentException("Expected a numeric value.");
            return convertedNumber;
            

        }
    }
}