namespace Demo12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Agenda :");
			Dictionary<DateTime, string> agenda = new Dictionary<DateTime, string>();
			string choix = "";
			do
			{
				if(agenda.Count > 0)
				{
					foreach (KeyValuePair<DateTime, string> entree in agenda)
					{
						Console.WriteLine($"{entree.Key}\t:\t{entree.Value}");
					}
				}
				else
				{
					Console.WriteLine("Pas encore de rendez-vous...");
				}
				Console.WriteLine("(A)jouter - (Q)uitter");
				choix = Console.ReadLine().ToUpper();
				switch (choix) {
					case "A":
						Console.WriteLine("À quelle date ajoutez-vous ce rendez-vous?");
						Console.WriteLine("Quel jour ?");
						int day = int.Parse(Console.ReadLine());
						Console.WriteLine("Quel mois?");
						int month = int.Parse(Console.ReadLine());
						Console.WriteLine("Quelle année?");
						int year = int.Parse(Console.ReadLine());
						Console.WriteLine("Quelle heure?");
						int hour = int.Parse(Console.ReadLine());
						Console.WriteLine("Quelle minute?");
						int minute = int.Parse(Console.ReadLine());
						DateTime dateKey = new DateTime(year, month, day, hour, minute, 0);
						if (agenda.ContainsKey(dateKey))
						{
							Console.WriteLine($"Un autre rendez-vous est déjà prévu à cette date :");
							Console.WriteLine(agenda[dateKey]);
						}
						else
						{
							Console.WriteLine("En quoi concerne ce rendez-vous ?");
							string objet = Console.ReadLine();
							agenda.Add(dateKey, objet);
						}
						break;
				}
			} while (choix != "Q");
			Console.WriteLine("Merci d'avoir utilisé Agenda 3000!");
		}
	}
}
