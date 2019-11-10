using System;

namespace Battle
{
    public static class Ex2
    {
        public static readonly Func<int, int> Triple = a => a * 3;
        public static readonly Func<int, int> Square = a => a * a;

        public static Func<T, R> Compose<T, U, R>(Func<U, R> f, Func<T, U> g) => a => f(g(a));

        // static void Main() => Console.WriteLine(Compose(Triple, Square)(5));
    }
}
