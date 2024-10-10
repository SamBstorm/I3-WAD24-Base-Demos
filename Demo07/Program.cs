namespace Demo07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Version WHILE
			Console.WriteLine("Veuillez introduire votre BBAN (12 chiffres) :");
			string userInput = Console.ReadLine();	//Initialise
			while (userInput.Length != 12 || !long.TryParse(userInput, out _))	//Condition
			{
				Console.WriteLine("Entrée invalide");
				userInput = Console.ReadLine();		//Modification (itération)
			}
			Console.WriteLine("Entrée valide"); */

			/*Version DO...WHILE*/
			string message = "Veuillez introduire votre BBAN (12 chiffres) :";
			string userInput;	//Déclaration (ATTENTION pas initialisation)
			do
			{
				Console.WriteLine(message);
				userInput = Console.ReadLine(); //Initialisation (1ère fois)
												//Modification (fois suivantes)
				message = "Entrée invalide";
			} while (userInput.Length != 12 || !long.TryParse(userInput, out _));
			Console.WriteLine("Entrée valide");
		}
	}
}
