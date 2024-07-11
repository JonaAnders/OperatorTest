namespace OperatorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Addable<int>(1);
            var b = new Addable<int>(2);
            Console.WriteLine(a + b);
        }
    }
}
