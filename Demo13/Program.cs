namespace Demo13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] menuOptions = { "Femme", "Homme", "Autre" };
			int selectedPosition = 0;
			string userChoice;
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
				Console.WriteLine("(M)onter - (D)escendre - (V)alider");
				userChoice = Console.ReadLine().ToUpper();
				if (userChoice == "M" && selectedPosition > 0)
				{
					selectedPosition--;
				}
				else if (userChoice == "D" && selectedPosition < menuOptions.Length - 1)
				{
					selectedPosition++;
				} 
			} while (userChoice != "V");

			Console.WriteLine($"Vous avez choisi : {menuOptions[selectedPosition]}");
		}
	}
}
