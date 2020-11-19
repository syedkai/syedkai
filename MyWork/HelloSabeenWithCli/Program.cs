using System;

namespace HelloSabeenWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Sabeen";
            String platform = "Cli";
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine($"Congrats on creating your first .Net application with {platform}");
            Console.WriteLine("Bye!");
        }
    }
}
