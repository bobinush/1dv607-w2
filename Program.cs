using System;
using System.Linq;
using W2.Models;

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
			db.LoadDatabase();
			var members = new MemberOpt();
			members.Main(db);

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
