using System;
using CSharpSupportEngineer.Model;

namespace CSharpSupportEngineer
{
    public static class Factory
    {
        public static Calculator CreateCalculator(IOutput output)
        {
            var t = Type.GetType("CSharpSupportEngineer.Modell.Calculator");
            object[] args2 = { output };
            object o = Activator.CreateInstance(t, args2);
            return o as Calculator;
        }
    }
}
