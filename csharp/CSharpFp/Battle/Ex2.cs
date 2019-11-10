using System;

namespace Battle
{
    public delegate Func<int, int> BinaryOperator(int i);

    public static class Ex2
    {
        public static readonly Func<int, int> Triple = a => a * 3;
        public static readonly Func<int, int> Square = a => a * a;

        public static Func<T, R> Compose<T, U, R>(Func<U, R> f, Func<T, U> g) => a => f(g(a));

        public static Func<Func<T, R>, Func<Func<U, T>, Func<U, R>>> 
        CurryCompose<T, U, R>() => f => g => a => f(g(a));

        public static Func<Func<U, T>, Func<Func<T, R>, Func<U, R>>>
        HigherAndThen<T, U, R>() => g => f => a => f(g(a));

        public static BinaryOperator Add = a => b => a + b;
        public static BinaryOperator Mul = a => b => a * b;

        // static void Main() => Console.WriteLine(Compose(Triple, Square)(5));
    }
}
