using System;
using System.Collections.Generic;
using CSharpSupportEngineer.Model;

namespace CSharpSupportEngineer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleOutput = new ConsoleOutput();
            var calc = Factory.CreateCalculator(consoleOutput);
            Multiply(calc);
            consoleOutput.WriteLine("**********************************************");
            SumFromPlainText(calc);
            consoleOutput.WriteLine("**********************************************");
            SumEvenNumbersFromStack(calc);
            consoleOutput.WriteLine("**********************************************");
            SumNumbers(calc);
            consoleOutput.WriteLine("**********************************************");
            Console.WriteLine("Press key to terminate.");
            Console.ReadKey();
        }

        private static void Multiply(Calculator calculator)
        {
            calculator.Multiply(2.15m, 4.20m);
        }

        private static void SumFromPlainText(Calculator calculator)
        {
            calculator.SumFromPlainText("We sum the following number: 4.75 then 5 and 7 and finally 10.");
        }

        private static void SumEvenNumbersFromStack(Calculator calculator)
        {
            calculator.SumEvenNumbersFromStack(new[] {5m, 6m, 12m, 15m});
        }

        private static void SumNumbers(Calculator calculator)
        {
            var numbers = new List<Number>();
            numbers.Add(new Number(79));
            numbers.Add(new Number(12));
            numbers.Add(new Number(154));
            numbers.Add(new Number(56));
            calculator.SumNumbers(numbers);
        }
    }
}
