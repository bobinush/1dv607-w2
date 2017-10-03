using System;

namespace W2.Views
{
	public class View
	{
		public int ShowStartMenu(string title)
		{
			Console.WriteLine(title);
			Console.WriteLine("1 Show | 2 Create | 3 Exit");
			return GetMenuChoice();
		}

		public string Question(string question)
		{
			Console.WriteLine(question);
			return GetUserInput();
		}
		public void Message(string msg)
		{
			Console.WriteLine(msg);
		}

		private int GetMenuChoice()
		{
			bool answered = false;
			int result = 0;
			while (!answered)
			{
				answered = int.TryParse(Console.ReadLine(), out result);
			}
			return result;
		}
		private string GetUserInput()
		{
			bool answered = false;
			string input = "";
			while (!answered)
			{
				input = Console.ReadLine();
				answered = !string.IsNullOrWhiteSpace(input);
			}
			return input;
		}

		public void showInfo(string infoMsg)
		{
			Console.WriteLine(infoMsg);
		}

		public void showError(string errorMsg)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(errorMsg);
			Console.ResetColor();
		}
	}
}
