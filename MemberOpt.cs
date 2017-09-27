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
			Console.WriteLine("1 Show | 2 Create");
			int showOrCreate = Int32.Parse(Console.ReadLine());
			if(showOrCreate == 1)
			{
				Console.WriteLine("1 Verbose | 2 Compact");
				int verboseOrCompact = Int32.Parse(Console.ReadLine());
				if(verboseOrCompact == 1)
				{
				foreach (Member mem in db.GetAllMembers())
				{
					Console.WriteLine(mem.ToVerbose());
				}	
				}
				else if(verboseOrCompact == 2)
				{
				foreach (Member mem in db.GetAllMembers())
				{
					Console.WriteLine(mem.ToCompact());
				}	
				}
				Console.WriteLine(db.GetAllMembers());
				Console.WriteLine("Choose member by ID");
				int findMember = Int32.Parse(Console.ReadLine());
				if (findMember = db.Members.Find(x => x.Id == id))
					
					{
						Console.WriteLine("1 Edit | 2 Delete | 3 Show boats");

						int memberChoises = Int32.Parse(Console.ReadLine());
						
						if(memberChoises == 1)
						{
							Console.WriteLine("Name");
							string nameEdit = Console.ReadLine();

							Console.WriteLine("Personal number");
							string personalNumberEdit = Console.ReadLine();
							db.Save();
						}
						else if(memberChoises == 2)
						{
							Console.WriteLine("Are you sure? Yes/no");
							string deleteOpt = Console.ReadLine();
							
							if (deleteOpt == "Yes")
							{
								db.Delete();
								foreach (Member mem in db.GetAllMembers())
								{
									Console.WriteLine(db.GetAllMembers());
								}	
							}
							else if(deleteOpt == "no")
							{
								foreach (Member mem in db.GetAllMembers())
								{
									Console.WriteLine(db.GetAllMembers());
								
								}
							}	
						}
					}

			}
			else if(showOrCreate == 2)
			{
				Console.WriteLine("Name");
				string name = Console.ReadLine();

				Console.WriteLine("Personal number");
				string personalNumber = Console.ReadLine();

				var newMember = new Member(name, personalNumber);
				
				File.WriteAllText("memberInformation.txt", "Name :" + newMember.Name + "\n" +
					"Personal number: " + newMember.PersonalNumber + "\n" +
					"Member ID: " + newMember.Id + "\n" +
					"Number of boats: " + newMember.numberOfBoats);
				db.Save(newMember);
			}
			// list all members
			// get id
			int id = int.Parse(Console.ReadLine());
			Member member = db.GetMemberById(id);
			Console.WriteLine("Write 'delete', 'change' or 'boat'");
			string answer = Console.ReadLine();


			if (answer == "boat")
			{
				EnterBoatSection(member);
			}

				// visar alla members + member id
				Console.WriteLine("Which member? ");
				int findMemberId = Int32.Parse(Console.ReadLine());
				Member chosenMember = db.GetMemberById(id);

				Console.WriteLine("1 Edit | 2 Delete | 3 View Boat");
				int memberChoises = Int32.Parse(Console.ReadLine());

				if (memberChoises == 1)
				{
					
				}
				else if (memberChoises == 2)
				{
					//show members
					Console.WriteLine("Write which memberID you wanna delete");
					string deleteMember = Console.ReadLine();
					
				}
			}
		}
		private void EnterBoatSection(Member member)
		{
			var b = new BoatOpt();
			b.DoBoatList(member, db);
		}
	}
}