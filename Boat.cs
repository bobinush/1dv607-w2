using System; 

namespace W2
{
class Boat
{
	static void Main(string[] args)
	{
		//private Boats(){
			//skapa en lista med alla båtar
		//}

		//START
		  Console.WriteLine("1 - delete | 2 - change | 3 - create | 4 - show all boats|");
			string choices = Console.ReadLine();
			double input_Nmbr = Int32.Parse(choices);
            
				//DELETE
			if (input_Nmbr == 1){

			Console.WriteLine("Wich boat do you want to delete?");
			//visa båtar Boats()
			} 

			if (input_Nmbr == 2){
				Console.WriteLine("Wich boat do you want to change?");
				//visa båtar Boats()
			}

			if(input_Nmbr == 3){
				Console.WriteLine("Choose type:"); 
				Console.WriteLine("1 - Sailboat | 2 - Motorsailer | 3 - Kayak/Canoe | 4 - Other|");

				Console.WriteLine("Enter a length for the boat");

			}

			if(input_Nmbr == 4){
				//Visa båtar Boats()
			}
		




	}
	

}


}