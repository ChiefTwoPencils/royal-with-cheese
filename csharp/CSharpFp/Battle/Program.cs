using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Func<string>> place = azz => () => $"Your {azz} done been {azz.ToLower()}-ed!";
            Func<string> placeFooAzz = place("FOO");
            Func<string> placeBarAzz = place("BAR");
            Console.WriteLine(placeFooAzz());
            Console.WriteLine(placeBarAzz());
        }
    }
}
