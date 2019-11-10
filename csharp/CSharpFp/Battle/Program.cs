using System;
using System.Collections.Generic;

using static Battle.Ex2;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
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

            // Exercise 2.1
            Console.WriteLine(Compose(Triple, Square)(5));
        }
    }
}
