using System;

namespace CSharpSupportEngineer
{
    public sealed class ConsoleOutput : IOutput
    {
        public void WriteLine(int value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(decimal value)
        {
            Console.WriteLine(value);
        }
    }
}
