using System;
using System.IO;
using W2.Models;
using W2.Views;

namespace W2
{
	class MemberOpt
	{
		private Database db;
		public void Main(Database database, View view)
		{
			db = database;
			int showOrCreate = 0;
			// create or show members
			do
			{
				showOrCreate = view.ShowStartMenu();
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
					Console.WriteLine("Choose member by ID");
					int id = Int32.Parse(Console.ReadLine());
					Member member = db.GetMemberById(id);
					Console.WriteLine("1 Edit | 2 Delete | 3 Show boats");
					int memberChoises = Int32.Parse(Console.ReadLine());

					if (memberChoises == 1) // Edit
					{
						string nameEdit = view.Question("Name");
						string personalNumberEdit = view.Question("Personal number");
						member.Name = nameEdit;
						member.PersonalNumber = personalNumberEdit;
						db.Save(member);
					}
					else if (memberChoises == 2) // Delete
					{
						string deleteOpt = view.Question("Are you sure? Yes/no");

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
						EnterBoatSection(member, view);
					}

				}
				else if (showOrCreate == 2) // Create
				{
					string name = view.Question("Name");
					string personalNumber = view.Question("Personal number");
					var newMember = new Member(name, personalNumber);

					db.Save(newMember);
				}
			} while (showOrCreate != 3); // 3 = Exit
		}
		private void EnterBoatSection(Member member, View view)
		{
			var b = new BoatOpt();
			b.DoBoatList(member, db, view);
		}
	}
}