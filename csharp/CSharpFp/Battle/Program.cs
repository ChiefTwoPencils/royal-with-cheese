using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo(string azz) => $"Your {azz} done been Foo-ed!";
            Func<string, string> bar = azz => $"Your {azz} done been Foo-ed!";
            Console.WriteLine($"{foo("Oh, yes today!")}\tDaaaaaammmmnnnn!!!");
            Console.WriteLine($"{bar("Fooey")}\tTake your pick!!!");
        }
    }
}
