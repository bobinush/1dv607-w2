using System;
using System.IO;
using W2.Models;

namespace W2
{
	class BoatOpt
	{
		public void Boats(string[] args)
		{
			Console.WriteLine("1 Delete | 2 Change | 3 Create |");
			string choices = Console.ReadLine();
			double inputChoice = Int32.Parse(choices);

			//DELETE
			if (inputChoice == 1)
			{
				Console.WriteLine("Wich members boat do you want to delete?");
				//visa en lista över medlemmarna 
			}

			//CHANGE
			else if (inputChoice == 2)
			{
				Console.WriteLine("Wich boat do you want to change?");
				//visa båtar BoatInformation()
			}

			//CREATE
			else if (inputChoice == 3)
			{
				Console.WriteLine("Choose type:");
				Console.WriteLine("1 Sailboat | 2 Motorsailer | 3 Kayak/Canoe | 4 Other|");
				string type = Console.ReadLine();
				int inputType = Int32.Parse(type);

				Console.WriteLine("Enter the boats length (meters)");
				string length = Console.ReadLine();
				int inputLenght = Int32.Parse(length);

				var boat = new Boat(inputType, inputLenght);
				//spara till databas
				//ROBIN returnerar ett meddelande som visar att det är okej
				Console.WriteLine("The boat has been saved!");
			}
			else
			{
				Console.WriteLine("You need to answer 1 Delete, 2 Change & 3 Create");
			}





		}


	}


}