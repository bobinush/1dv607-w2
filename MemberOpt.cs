using System;
using System.IO;
using W2.Models;

namespace W2
{
	class MemberOpt
	{
		 public void DoMemberList(string[] args)
		 { 
			Console.WriteLine("1 Create | 2 Show");
			string answer = Console.ReadLine();

			if(answer == "1")
			{
				Console.WriteLine("Name");
				string name = Console.ReadLine();
				
				Console.WriteLine("Personal number");
				string personalNumber = Console.ReadLine();
				
				var member = new Member(name, personalNumber);
				//spara till memberInformation.txt
				File.WriteAllText("memberInformation.txt", "Name :" + member.Name + "\n" + 
					"Personal number: " + member.PersonalNumber + "\n" + 
					"Member ID: " + member.Id + "\n" + 
					"Number of boats: " +  member.numberOfBoats);

				Console.WriteLine("The member has been saved!");
				// string text = System.IO.File.ReadAllText(@"C:\wamp64\www\1dv610\1dv607-w2\memberInformation.txt");
				
			}		
					else if(answer == "2")
			{
				// visar alla members + member id
				Console.WriteLine("Which member? ");
				int findMemberId = Int32.Parse(Console.ReadLine());
				Member chosenMember = Member.member.Find(x => x.Id == id);

				Console.WriteLine("1 Edit | 2 Delete | 3 View Boat");
				int memberChoises = Int32.Parse(Console.ReadLine());

				if(memberChoises == 1)
			{
				Console.WriteLine("Name");
				string nameEdit = Console.ReadLine();
				
				Console.WriteLine("Personal number");
				string personalNumberEdit = Console.ReadLine();

				//save
				Member.Save();
			}
				else if(memberChoises == 2)
				{
					//show members
					Console.WriteLine("Write which memberID you wanna delete");
					string deleteMember = Console.ReadLine();

					if(deleteMember = Member.member.Find(x => x.Id == id))
					{	
						Console.WriteLine("Are you sure? Yes/no");
						
						string deleteOpt = Console.ReadLine();
						if(deleteOpt == "yes")
						{
							//deletea
							Member.Delete();
							// gå tillbaka till show memberlist
							Show.MemberList();
						}
					}
				}
	
	
			}
			else
			{
				Console.WriteLine("You need to answer '1' create or '2' show");
			}
		 }
		 public class Create
		 {
			 
		 }
	}
}