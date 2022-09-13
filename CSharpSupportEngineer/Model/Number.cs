namespace CSharpSupportEngineer.Model
{
    public sealed class Number
    {
        public Number(decimal value)
        {
            Value = value;
        }
        public decimal Value { get; set; }
    }
}
