using System;

namespace W2.Views
{
	public class BoatView
	{
		public int Question(string question)
		{
			bool answered = false;
			int result = 0;
			while (!answered)
			{
				Console.WriteLine(question);
				answered = int.TryParse(Console.ReadLine(), out result);
			}
			return result;
		}
	}
}
