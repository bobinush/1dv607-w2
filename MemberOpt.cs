using System;
using System.IO;
using W2.Models;

namespace W2
{
	class MemberOpt
	{
		private Database db;
		public void Main(Database database)
		{
			db = database;
			// create or show members
			// list all members
			// get id
			int id = int.Parse(Console.ReadLine());
			Member member = db.GetMemberById(id);
			Console.WriteLine("Write 'delete', 'change', 'create' or 'show'");
			string answer = Console.ReadLine();

			if (answer == "boat")
			{
				EnterBoatSection(member);
			}
			// if(answer == "delete")
			// {
			// 	//show members
			// 	Console.WriteLine("Write which member you wanna delete");
			// 	string deleteMember = Console.ReadLine();

			// 	if(deleteMember == memberInList)
			// 	{	
			// 		//radera medlemmen
			// 		Console.WriteLine("The member has been removed");
			// 	}
			// }
			// else if(answer == "change")
			// {
			// 	Console.WriteLine(memberInList);
			// 	Console.WriteLine("Write which member you wanna change");
			// 	string changeMember = Console.ReadLine();
			// 	if(changeMember == memberInList)
			// 	{
			// 		//ändra den
			// 		//spara den
			// 	}
			// }
			if (answer == "create")
			{
				Console.WriteLine("Name");
				string name = Console.ReadLine();

				Console.WriteLine("Personal number");
				string personalNumber = Console.ReadLine();

				var newMember = new Member(name, personalNumber);
				//spara till memberInformation.txt
				File.WriteAllText("memberInformation.txt", "Name :" + newMember.Name + "\n" +
					"Personal number: " + newMember.PersonalNumber + "\n" +
					"Member ID: " + newMember.Id + "\n" +
					"Number of boats: " + newMember.numberOfBoats);

				Console.WriteLine("The member has been saved!");
				// string text = System.IO.File.ReadAllText(@"C:\wamp64\www\1dv610\1dv607-w2\memberInformation.txt");

			}

			// else if(answer == "show")
			// {
			// 	//show list ex, for loop som går igenom alla 
			// 	Console.WriteLine("Do you want the members in a 'compact' list or 'verbose' list?");
			// 	string listAnswer = Console.ReadLine();
			// 	if(listAnswer == "compact")
			// 	{
			// 		Console.WriteLine(compactList);
			// 	}
			// 	else if(listAnswer == "verbose")
			// 	{
			// 		Console.WriteLine(verboseList);
			// 	}
			// 	else
			// 	{
			// 		Console.WriteLine("You need to answer compact or verbose");
			// 	}

			// }
			else
			{
				Console.WriteLine("You need to answer change, delete, create or show");
			}
		}
		private void EnterBoatSection(Member member)
		{
			var b = new BoatOpt();
			b.DoBoatList(member, db);
		}
	}
}