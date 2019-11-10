using System;

using BinaryOperator = System.Func<int, System.Func<int, int>>;

namespace Battle
{
    public static class Ex2
    {
        public static readonly Func<int, int> Triple = a => a * 3;
        public static readonly Func<int, int> Square = a => a * a;

        public static Func<T, R> Compose<T, U, R>(Func<U, R> f, Func<T, U> g) => a => f(g(a));

        public static BinaryOperator Add = a => b => a + b;
        public static BinaryOperator Mul = a => b => a * b;

        // static void Main() => Console.WriteLine(Compose(Triple, Square)(5));
    }
}
