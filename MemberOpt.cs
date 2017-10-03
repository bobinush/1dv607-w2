using System;
using W2.Models;
using W2.Views;

namespace W2
{
	class MemberOpt
	{
		private Database db;
		public bool Main(Database database, View view)
		{
			db = database;
			int showOrCreate = 0;
			// create or show members
			do
			{
				showOrCreate = view.ShowStartMenu("Members");
				if (showOrCreate == 1) // Show
				{
					int verboseOrCompact = Int32.Parse(view.Question("1 Verbose | 2 Compact"));
					if (verboseOrCompact == 1)
					{
						foreach (Member mem in db.GetAllMembers())
						{
							view.showInfo(mem.ToVerbose());
						}
					}
					else if (verboseOrCompact == 2)
					{
						foreach (Member mem in db.GetAllMembers())
						{
							view.showInfo(mem.ToCompact());
						}
					}
					Member member = null;
					while (member == null)
					{
						int id = Int32.Parse(view.Question("Choose member by ID"));
						member = db.GetMemberById(id);
					}
					view.showInfo(member.ToVerbose());
					int memberChoises = Int32.Parse(view.Question("1 Edit | 2 Delete | 3 Show boats"));
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
						string deleteOpt = view.Question("Are you sure? y/n");
						if (deleteOpt == "y")
						{
							db.Delete(member.Id);
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
			return false;
		}
		private void EnterBoatSection(Member member, View view)
		{
			var b = new BoatOpt();
			b.DoBoatList(member, db, view);
		}
	}
}