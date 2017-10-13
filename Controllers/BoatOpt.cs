using System;
using W2.Models;
using W2.Views;

namespace W2
{
	class BoatOpt
	{
		private Database db;
		public void DoBoatList(Member member, Database database, View view)
		{
			db = database;
			int inputChoice = 0;
			do
			{
				inputChoice = view.ShowStartMenu("Boats");
				if (inputChoice == 1) // Show
				{
					foreach (Boat boat in member.Boats)
					{
						view.showInfo(boat.ToString());
					}

					int id = Int32.Parse(view.Question("Choose a boat by ID"));
					Boat chosenBoat = member.GetBoat(id);

					inputChoice = Int32.Parse(view.Question("1 Edit | 2 Delete | 3 Exit"));
					if (inputChoice == 1) // Edit
					{
						Boat newBoatInfo = InputBoatInformation(view);
						member.UpdateBoat(chosenBoat, newBoatInfo);
					}

					else if (inputChoice == 2) // Delete
					{
						string answer = view.Question("Are you sure? y/n");
						if (answer == "y")
						{
							member.DeleteBoat(id);
						}
					}
				}
				else if (inputChoice == 2) // Create
				{
					Boat boat = InputBoatInformation(view);
					member.AddBoat(boat);

					if (db.Save(member))
					{
						view.showInfo("The boat has been saved!");
					}
					else
					{
						view.showError("Something went wrong!");
					}
				}
			} while (inputChoice != 3); // 3 = Exit
		}

		private Boat InputBoatInformation(View view)
		{
			view.showInfo("Choose type:");
			int inputType = Int32.Parse(view.Question("1 Sailboat | 2 Motorsailer | 3 Kayak/Canoe | 4 Other"));
			double inputLenght = Convert.ToDouble(view.Question("Enter the boats length (ft)"));
			var boat = new Boat(inputType, inputLenght);
			return boat;
		}
	}
}