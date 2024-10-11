namespace Demo10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] dayNames = { 
				"dimanche", 
				"lundi",
				"mardi",
				"mercredi",
				"jeudi",
				"vendredi",
				"samedi"
			};
			/* Aussi déclarable avec les  [] 
			 string[] dayNames = [ 
				"dimanche", 
				"lundi",
				"mardi",
				"mercredi",
				"jeudi",
				"vendredi",
				"samedi"
			];
			 */

			Console.WriteLine($"Il y a {dayNames.Length} jours de la semaine.");

			foreach (string dayName in dayNames) {
				Console.WriteLine($"\t- {dayName}");
			}

			/*Console.WriteLine("En anglais, comment traduisez-vous :");
			for (int i = 0; i < dayNames.Length; i++) {
				Console.Write($"\t- {dayNames[i]}\t:");
				dayNames[i] = Console.ReadLine();
			}*/

			Console.WriteLine($"Aujourd'hui nous sommes {dayNames[(int)DateTime.Now.DayOfWeek]} le {DateTime.Now.ToString("dd MMMM yyyy")}.");
		}
	}
}
