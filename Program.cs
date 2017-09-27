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
			var member = new Member("Robin", "910524-xxxx");
			var boat = new Boat((int)Enums.BoatTypes.KayakCanoe, 14.1);
			member.AddBoat(boat);
			member.AddBoat(boat);
			db.Save(member);
			member.Name = "kalle anka";
			db.Save(member);
			var newBoat = new Boat(2, 1.3);
			member.UpdateBoat(boat, newBoat);
			db.Save(member);
			var membersList = db.GetAllMembers();
			membersList.ForEach(x => Console.WriteLine(x.ToVerbose()));
			member.DeleteBoat(boat.Id);
			membersList.ForEach(x => Console.WriteLine(x.ToVerbose()));

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
