using System;
using System.IO;
using W2.Models;

namespace W2
{
	class BoatOpt
	{
		public void Boats(string[] args)
		{

			//START
			Console.WriteLine("Delete | Change | Create |");
			string choices = Console.ReadLine();


			//DELETE
			if (choices == "Delete")
			{

				Console.WriteLine("Wich boat do you want to delete?");
				//visa båtar BoatInformation()
			}

			//CHANGE
			else if (choices == "Change")
			{
				Console.WriteLine("Wich boat do you want to change?");
				//visa båtar BoatInformation()
			}

			//CREATE
			else if (choices == "Create")
			{
				Console.WriteLine("Choose type:");
				Console.WriteLine("1 Sailboat | 2 Motorsailer | 3 Kayak/Canoe | 4 Other|");
				string type = Console.ReadLine();
				int inputType = Int32.Parse(type);


				Console.WriteLine("Enter the boats length (meters)");
				string length = Console.ReadLine();
				double inputLenght = Int32.Parse(length);

				var boat = new Boat(inputType, inputLenght);
				//spara till databas
				//ROBIN returnerar ett meddelande som visar att det är okej
				Console.WriteLine("The boat has been saved!");
			}
			else
			{
				Console.WriteLine("You need to answer Delete, Change & Create");
			}





		}


	}


}