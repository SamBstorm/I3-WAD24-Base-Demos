namespace Demo08
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string PASSWORD = "Test1234=";
			int countdown = 3;
			string password;
			do
			{
				Console.WriteLine($"Veuillez introduire votre mot de passe : ({countdown} essais restant)");
				password = Console.ReadLine();
				countdown--;
			} while (password != PASSWORD && countdown > 0);

			if(password is PASSWORD)
			{
				Console.WriteLine("Bienvenue!");
			}
			else
			{
				Console.WriteLine("Compte bloqué!");
			}
		}
	}
}
