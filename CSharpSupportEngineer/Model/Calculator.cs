using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpSupportEngineer.Model
{
    public sealed class Calculator
    {
        private static Regex _numberRegex = new Regex(@"[0-9]+\.?[0-9,]*", RegexOptions.Compiled); //regex only matched integers.
        private readonly IOutput _output;
        private NumberCache _numberCache = new NumberCache();
        public Calculator(IOutput output)
        {
            _output = output ?? throw new ArgumentNullException(nameof(output));
        }
        public decimal Multiply(decimal op1, decimal op2)
        {
            _output.WriteLine($"Multiplying {op1} with {op2}");
            var result = op1 * op2;
            _output.WriteLine($"Operations result is:");
            _output.WriteLine(result.ToString(".00"));
            return result;
        }

        public decimal SumFromPlainText(string value)
        {
            _output.WriteLine($"Summing from plain text: '{value}'");
            var matches = _numberRegex.Matches(value);
            decimal sum = 0;
            foreach (var match in matches)
            {
                //the cultureinfo is only good practice, but only needed if the values come with a different decimal seperator than the system default.
                sum += Convert.ToDecimal(match.ToString(), new CultureInfo("de-CH")); 
            }

            _output.WriteLine($"Operations result is:");
            _output.WriteLine(sum);
            return sum;
        }

        public decimal SumEvenNumbersFromStack(decimal[] oddNumbers)
        {
            _output.WriteLine($"Summing even ('gerade') numbers from: '{string.Join(",", oddNumbers.ToList())}'");
            var result = oddNumbers.Where(s => s % 2 == 0).Select(s => s).Sum(); //modulo instead of division
            _output.WriteLine($"Sum even numbers: '{result}'");
            return result;
        }

        public decimal SumNumbers(List<Number> numbers)
        {
            _output.WriteLine("Summing numbers from:");
            numbers.ForEach(s =>
            {
                _output.WriteLine(s.Value);

            });
            
            decimal sum = 0;
            _numberCache.BuildCache(numbers);
            numbers.ForEach(s =>
            {
                sum += s.Value;
            });

            _output.WriteLine($"Sum numbers: '{sum}'");
            return sum;
        }
    }
}
