namespace Demo13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] menuOptions = { "Femme", "Homme", "Autre" };
			int selectedPosition = 0;
			ConsoleKey userChoice;
			do
			{
				Console.Clear();
				Console.WriteLine("Veuillez sélectionner votre genre :");
				for (int i = 0; i < menuOptions.Length; i++)
				{
					string option = menuOptions[i];
					if (i == selectedPosition)
					{
						Console.WriteLine($"[{option}]");
					}
					else
					{
						Console.WriteLine(option);
					}
				}
				Console.WriteLine("↑ (M)onter - ↓ (D)escendre - \"Enter\" / (V)alider");
				userChoice = Console.ReadKey(true).Key;
				if ((userChoice == ConsoleKey.M || userChoice == ConsoleKey.UpArrow) && selectedPosition > 0)
				{
					selectedPosition--;
				}
				else if ((userChoice == ConsoleKey.D || userChoice == ConsoleKey.DownArrow) && selectedPosition < menuOptions.Length - 1)
				{
					selectedPosition++;
				} 
			} while (userChoice != ConsoleKey.V && userChoice != ConsoleKey.Enter);

			Console.WriteLine($"Vous avez choisi : {menuOptions[selectedPosition]}");
		}
	}
}
