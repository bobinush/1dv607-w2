using System;

namespace W2
{
	class Member
	{
		 static void Main(string[] args)
		 { 
			Console.WriteLine("Write 'delete', 'change', 'create' or 'show' members?");
			string answer = Console.ReadLine();
			
			if(answer == "delete")
			{
				//show members
				Console.WriteLine("Write which member you wanna delete");
				string deleteMember = Console.ReadLine();

				if(deleteMember == MemberInList)
				{	
					//radera medlemmen
					Console.WriteLine("The member has been removed");
				}
			}
			else if(answer == "change")
			{
				//show members
				Console.WriteLine("Write which member you wanna change");
				string changeMember = Console.ReadLine();
				if(changeMember == MemberInList)
				{
					//ändra den
					//spara den
				}
			}
			else if(answer == "create")
			{
				Console.WriteLine("Name");
				string name = Console.ReadLine();
				Console.WriteLine("Member ID");
				string memberID = Console.ReadLine();
				Console.WriteLine("Number of boats");
				string numberOfBoats = Console.ReadLine();
				Console.WriteLine("Boat details");
				string boatDetails = Console.ReadLine();
				Console.WriteLine("Personal number");
				
			}
			else if(answer == "show")
			{
				//show list
				Console.WriteLine(MembersList);
				if(MembersList)
				{

				}
			}
			else
			{
				Console.WriteLine("You need to answer change, delete, create or show");
			}
		 }
	}
}