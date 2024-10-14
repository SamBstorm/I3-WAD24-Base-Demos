namespace Demo11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Liste des présences :");
			List<string> presence = new List<string>();
			string name = "";
			do
			{
				Console.WriteLine($"Veuillez introduire le nom d'un élève présent :");
				Console.WriteLine($"(Pour finaliser les présences, écrivez \"FIN\")");
				name = Console.ReadLine().ToUpper();
				if (!presence.Contains(name))
				{
					presence.Add( name );
				}
				else
				{
					Console.WriteLine($"L'élève \"{name}\" déjà présent...");
				}
			} while (name != "FIN");
			presence.Remove("FIN");
			while (presence.Count > 0)
			{
				Console.WriteLine("Actuellement, sont présents :");
				int i = 0;
				foreach (string eleve in presence)
				{
					Console.WriteLine($"\t{++i}) {eleve}");
				}
				int choix;
				do
				{
					Console.WriteLine($"Indiquer le numéro d'un élève partant :");
				} while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > presence.Count);

				
				
				string elevePartant = presence[choix - 1];
				Console.WriteLine($"Êtes-vous sûre de vouloir supprimer l'élève \"{elevePartant}\" ? (Oui - Non)");
				if (Console.ReadLine().ToUpper() == "OUI")
				{
					presence.Remove(elevePartant);
				} 
			}
			Console.WriteLine("Merci d'avoir utilisé présence 3000!");
		}
	}
}
