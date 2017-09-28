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
			int showOrCreate = 0;
			// create or show members
			do
			{
				Console.WriteLine("1 Show | 2 Create | 3 Exit");
				showOrCreate = Int32.Parse(Console.ReadLine());
				if (showOrCreate == 1) // Show
				{
					Console.WriteLine("1 Verbose | 2 Compact");
					int verboseOrCompact = Int32.Parse(Console.ReadLine());
					if (verboseOrCompact == 1)
					{
						foreach (Member mem in db.GetAllMembers())
						{
							Console.WriteLine(mem.ToVerbose());
						}
					}
					else if (verboseOrCompact == 2)
					{
						foreach (Member mem in db.GetAllMembers())
						{
							Console.WriteLine(mem.ToCompact());
						}
					}
					//Console.WriteLine(db.GetAllMembers());
					Console.WriteLine("Choose member by ID");
					int id = Int32.Parse(Console.ReadLine());
					Member member = db.GetMemberById(id);
					Console.WriteLine("1 Edit | 2 Delete | 3 Show boats");
					int memberChoises = Int32.Parse(Console.ReadLine());

					if (memberChoises == 1) // Edit
					{
						Console.WriteLine("Name");
						string nameEdit = Console.ReadLine();

						Console.WriteLine("Personal number");
						string personalNumberEdit = Console.ReadLine();
						member.Name = nameEdit;
						member.PersonalNumber = personalNumberEdit;
						db.Save(member);
					}
					else if (memberChoises == 2) // Delete
					{
						Console.WriteLine("Are you sure? Yes/no");
						string deleteOpt = Console.ReadLine();

						if (deleteOpt == "Yes")
						{
							db.Delete(member.Id);
							foreach (Member mem in db.GetAllMembers())
							{
								Console.WriteLine(db.GetAllMembers());
							}
						}
						else if (deleteOpt == "no")
						{
							foreach (Member mem in db.GetAllMembers())
							{
								Console.WriteLine(db.GetAllMembers());

							}
						}
					}
					else if (memberChoises == 3) //Boats
					{
						EnterBoatSection(member);
					}

				}
				else if (showOrCreate == 2) // Create
				{
					Console.WriteLine("Name");
					string name = Console.ReadLine();

					Console.WriteLine("Personal number");
					string personalNumber = Console.ReadLine();

					var newMember = new Member(name, personalNumber);

					db.Save(newMember);
				}
			} while (showOrCreate != 3);
		}
		private void EnterBoatSection(Member member)
		{
			var b = new BoatOpt();
			b.DoBoatList(member, db);
		}
	}
}