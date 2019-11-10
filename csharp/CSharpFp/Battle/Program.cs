using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, Func<string>> place = azz => () => $"Your {azz} done been Foo-ed!";
            Func<string> placeFooAzz = place("FOO");
            Console.WriteLine(placeFooAzz);
        }
    }
}
