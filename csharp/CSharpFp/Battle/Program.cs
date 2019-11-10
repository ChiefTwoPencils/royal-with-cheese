using System;
using System.Collections.Generic;

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
            var list = new List<Func<string>>
            {
                good("FOO"), good("BAR"), badd(null)
            };
            list.ForEach(p => Console.Write($"{p()}\n"));
        }
    }
}
