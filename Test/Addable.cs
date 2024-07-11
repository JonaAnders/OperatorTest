using System.Numerics;

namespace OperatorTest
{
    internal class Addable<T> where T : IAdditionOperators<T, T, T>, IFormattable
    {
        T x;
        public Addable(T a)
        {
            x = a;
        }
        public static Addable<T> operator +(Addable<T> a, Addable<T> b)
        {
            return new(a.x + b.x);
        }

        public override string ToString()
        {
            return x.ToString();
        }
    }
}
