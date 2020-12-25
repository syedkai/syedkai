using System;
namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello in .Net World");
			Console.WriteLine("\nWhat's your name? ");
			var name = Console.ReadLine();
			var date = DateTime.Now;
			Console.WriteLine($"\nHello, {name}, on {date:d}, at {date:t}!");
			Console.Write("\nPress any key to exit...");
			Console.ReadKey(true);
		}
	}
}