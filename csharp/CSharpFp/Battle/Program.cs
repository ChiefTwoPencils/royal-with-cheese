using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Func<string, Func<string>>> place = state => azz => () 
                => $"{state}: Your {azz ?? "uh, oh!"} done been {azz?.ToLower() ?? "whoops"}-ed!";
            Func<string, Func<string>> good = place("Good");
            Func<string, Func<string>> badd = place("Badd");
            Func<string> goodFoo = good("FOO");
            Func<string> goodBar = good("BAR");
            Func<string> badNull = badd(null);
            Console.WriteLine($"{goodFoo()}\n{goodBar()}\n{badNull()}");
        }
    }
}
