using System;
using System.IO;


namespace W2
{
	class Member
	{
		 static void Main(string[] args)
		 { 
			Console.WriteLine("Write 'delete', 'change', 'create' or 'show' members?");
			string answer = Console.ReadLine();
			
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
			if(answer == "create")
			{
				Console.WriteLine("Name");
				string name = Console.ReadLine();
				
				Console.WriteLine("Personal number");
				long personalNumber = Convert.ToInt64(Console.ReadLine());
				
				Console.WriteLine("Member ID");
				int memberID =Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("Number of boats");
				int numberOfBoats = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("Boat details");
				string boatDetails = Console.ReadLine();
				
				//spara till memberInformation.txt
				File.WriteAllText("memberInformation.txt", name + "\n" + personalNumber + "\n" + memberID + "\n" + numberOfBoats + "\n" + boatDetails);
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
		 public class Create
		 {
			 
		 }
	}
}