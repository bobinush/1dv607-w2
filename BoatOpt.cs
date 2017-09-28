using System;
using System.IO;
using W2.Models;

namespace W2
{
	class BoatOpt
	{
		private Database db;
		public void DoBoatList(Member member, Database database)
		{
			db = database;
			int inputChoice = 0;

			do
			{
				Console.WriteLine("1 Create | 2 Show ");
				int createorShowBoat = Int32.parse(Console.ReadLine());
				if(createorShowBoat == 1){
					Boat boat = InputBoatInformation();
					member.AddBoat(boat);

					if(db.Save()){
					Console.WriteLine("The boat has been saved!");
					}else {
						Console.WriteLine("Something went wrong!");
					}
				}
			}else if( createorShowBoat == 2)
			{
					foreach (Boat boat in member.Boats){
					Console.WriteLine(boat.ToString());
					}

					Console.WriteLine("Choose a boat by ID");
					int id = Int32.Parse(Console.ReadLine());
					Boat chosenBoat = member.Boats.Find(x => x.Id == id);

					Console.WriteLine("1 Delete | 2 Change | 3 Exit");
					inputChoice = Int32.Parse(Console.ReadLine());
			
				//DELETE
				if (inputChoice == 1)
				{
					Console.WriteLine("Are you sure? Y/N");
					string answer = Console.ReadLine();
					if (answer == "Y")
					{
						member.DeleteBoat(id);
					}
				}

				//CHANGE
				else if (inputChoice == 2)
				{
					Boat newBoatInfo = InputBoatInformation();
					member.UpdateBoat(chosenBoat, newBoatInfo);
				}
			}
		}
			} while (inputChoice != 3); // 3 = exit
}

		private Boat InputBoatInformation()
		{
			Console.WriteLine("Choose type:");
			Console.WriteLine("1 Sailboat | 2 Motorsailer | 3 Kayak/Canoe | 4 Other|");
			string type = Console.ReadLine();
			int inputType = Int32.Parse(type);
			Console.WriteLine("Enter the boats length (ft)");
			string length = Console.ReadLine();
			double inputLenght = Convert.ToDouble(length);
			var boat = new Boat(inputType, inputLenght);
			return boat;

		}


	}


}