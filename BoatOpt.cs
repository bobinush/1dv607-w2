using System;
using System.IO;
using W2.Models;

namespace W2
{
	class BoatOpt
	{
		public void DoBoatList(Member member)
		{
			int inputChoice = 0;

			do
			{
				//visa en lista över medlemmens båtar
				// välj båt med id.
				int id = Int32.Parse(Console.ReadLine());
				Boat chosenBoat = member.Boats.Find(x => x.Id == id);

				Console.WriteLine("1 Delete | 2 Change | 3 Create | 4 Exit");
				inputChoice = Int32.Parse(Console.ReadLine());

				//DELETE
				if (inputChoice == 1)
				{
					Console.WriteLine("Are you sure? Y/N");
					string answer = Console.ReadLine();
					if(answer == "Y"){
						//member.deleteBoat(boat);
					}
				}

				//CHANGE
				else if (inputChoice == 2)
				{
					Boat boat = InputBoatInformation();
					chosenBoat.BoatType = boat.BoatType;
					chosenBoat.Length = boat.Length;
					// member.save()
				}

				//CREATE
				else if (inputChoice == 3)
				{
					Boat boat = InputBoatInformation();
					member.AddBoat(boat);
					//member.save();

					//if(Robin returns true){
						Console.WriteLine("The boat has been saved!");
					//}else {
				//}
					//}
					
				}
				else
				{
					Console.WriteLine("You need to answer 1 Delete, 2 Change & 3 Create");
				}
			} while (inputChoice != 4); // 4 = exit
		}

		private Boat InputBoatInformation()
		{
			Console.WriteLine("Choose type:");
			Console.WriteLine("1 Sailboat | 2 Motorsailer | 3 Kayak/Canoe | 4 Other|");
			string type = Console.ReadLine();
			int inputType = Int32.Parse(type);
			Console.WriteLine("Enter the boats length (meters)");
			string length = Console.ReadLine();
			double inputLenght = Convert.ToDouble(length);
			var boat = new Boat(inputType, inputLenght);
			return boat;

		}


	}


}