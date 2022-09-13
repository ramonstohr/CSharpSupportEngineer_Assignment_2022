using System;
using System.Collections.Generic;

namespace CSharpSupportEngineer.Model
{
    public sealed class NumberCache
    {
        private List<Number> _numberCache = new List<Number>();
        public void BuildCache(List<Number> numbers)
        {
            numbers.ForEach(s =>
            {
                _numberCache.Add(new Number(s.Value)); //generate a new number object with the same number from the original. Else it would be overriden in the Seed() function because of passing the reference in to the function.

            });

            Seed();
        }

        public void Seed()
        {
            Random rnd = new Random(200);
            _numberCache.ForEach(s =>
            {
                s.Value = rnd.Next(200);
            });
        }
    }
}
