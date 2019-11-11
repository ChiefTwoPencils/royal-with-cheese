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

        public static Func<T, R> Partial<T, U, R>(U u, Func<U, Func<T, R>> f) => f(u);
        public static Func<U, R> PartialBoth<K, U, R>(K k, Func<U, Func<K, R>> f) => u => f(u)(k);

        public static BinaryOperator Add = a => b => a + b;
        public static BinaryOperator Mul = a => b => a * b;

        public static Func<T, Func<U, Func<V, Func<W, string>>>> F<T, U, V, W>() 
            => t => u => v => w => string.Format("{0}, {1}, {2}, {3}", t, u, v, w);

        public static Func<A, Func<B, C>> Curry<A, B, C>(Func<Tuple<A, B>, C> f) 
            => a => b => f(Tuple.Create(a, b));

        public static Func<int, int> Factorial = n => n <= 1 ? n : n * Factorial(n - 1);

        // static void Main() => Console.WriteLine(Compose(Triple, Square)(5));
    }
}
