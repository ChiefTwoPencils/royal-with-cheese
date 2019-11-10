using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Func<string>> place = azz => () => $"Your {azz ?? "uh, oh!"} done been {azz?.ToLower() ?? "whoops"}-ed!";
            Func<string> placeFooAzz = place("FOO");
            Func<string> placeBarAzz = place("BAR");
            Func<string> placeNullAzz = place(null);
            Console.WriteLine(placeFooAzz());
            Console.WriteLine(placeBarAzz());
            Console.WriteLine(placeNullAzz());
        }
    }
}
