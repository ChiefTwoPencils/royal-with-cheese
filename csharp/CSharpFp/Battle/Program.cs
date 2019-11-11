using System;
using System.Collections.Generic;

using static Battle.Ex2;
using static Battle.EmailValidation;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base test
            const string fooBar = "foo@bar.baz";
            new List<string> { fooBar, null, "cr@zee.com", "" }
                .ForEach(email => Validate(email).Invoke());
        }

        static void IceBreaker()
        {
            // Ice breaker
            Func<string, Func<string, Func<string>>> place = state => azz => ()
                => $"{state}: Your {azz ?? "uh, oh!"} done been {azz?.ToLower() ?? "whoops"}-ed!";
            Func<string, Func<string>> good = place("Good");
            Func<string, Func<string>> badd = place("Badd");
            var list = new List<string>
            {
                good("FOO")(), good("BAR")(), badd(null)()
            };
            list.ForEach(Console.WriteLine);
        }
        static void Chapter2()
        {
            // Exercise 2.1, 2.2
            Console.WriteLine(Compose(Triple, Square)(5)); // 75

            // Exercise 2.3
            Console.WriteLine(Add(2)(3)); // 5
            var add2To = Add(2);
            Console.WriteLine(add2To(3)); // 5

            var multiply2By = Mul(2);
            Console.WriteLine(multiply2By(3)); // 6

            BinaryOperator sub = a => b => a - b;
            var from2Subtract = sub(2);
            Console.WriteLine(from2Subtract(3)); // -1

            // Exercise 2.5
            var tripleSquare = CurryCompose<int, int, int>()(Triple)(Square);
            Console.WriteLine(tripleSquare(5)); // 75

            // Exercise 2.6
            var tripleSquareFlipped = HigherAndThen<int, int, int>()(Square)(Triple);
            Console.WriteLine(tripleSquareFlipped(5)); // 75

            // Exercise 2.7 & 8
            Func<int, Func<int, int>> add = a => b => a + b;
            var add2Partial = PartialBoth(2, add);
            Console.WriteLine(add2Partial(3)); //5

            // Exercise 2.9
            var formatStrings = F<int, double, long, short>();
            var formattedString = formatStrings(42)(52.7)(42L)(1);
            Console.WriteLine(formattedString); // duh...

            // Exercise 2.10
            Func<Tuple<int, double>, string> tupleMul = t => $"{t.Item1 * t.Item2}";
            Console.WriteLine(Curry(tupleMul)(6)(7)); // 42

            // Exercise 2.11
            Func<double, Func<double, double>> addTax = x => y => x + x / 100 * y;
            Func<double, Func<double, double>> swaapp(Func<double, Func<double, double>> f) => y => x => f(x)(y);
            Console.WriteLine(swaapp(addTax)(0.09)(42.00)); // 42.0378

            // Exercise 2.12
            Console.WriteLine(Factorial(5)); // 120
        }
    }
}
