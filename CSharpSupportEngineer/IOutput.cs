namespace CSharpSupportEngineer
{
    public interface IOutput
    {
        void WriteLine(int value);
        void WriteLine(string value);
        void WriteLine(decimal value);
    }
}
