using System;
using System.Linq;
using W2.Models;
using W2.Views;

namespace W2
{
	class Program
	{
		static void Main(string[] args)
		{
			// string input;
			// do
			// {
			// 	try
			// 	{
			var db = new Database();
			var view = new View();
			var members = new MemberOpt();

			db.LoadDatabase();
			members.Main(db, view);

			// 	}
			// 	catch (Exception ex)
			// 	{
			// 		Console.WriteLine(ex.Message);
			// 		throw;
			// 	}

			// 	Console.WriteLine("You can write 'exit' to exit or 'start' to go to start");
			// 	input = Console.ReadLine();

			// } while (!input.Equals("exit", StringComparison.OrdinalIgnoreCase));
		}
	}
}
