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
                _numberCache.Add(s);

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
