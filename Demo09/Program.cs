namespace Demo09
{
	internal class Program
	{
		/*static Random RNG = new Random(); //Plus accessible en Orienté Objet*/
		static void Main(string[] args)
		{
			Random RNG = new Random();
			for (int nbLance = 0; nbLance < 2; nbLance++)
			{
				Console.WriteLine($"Un dé m'a sorti : {RNG.Next(1, 7)}"); //Valeur aléatoire entre 1 et 6 (7 non-inclu)
			}
		}
	}
}
