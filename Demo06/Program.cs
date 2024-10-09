namespace Demo06
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string email = "samuel.legrain@bstorm.be";
			int positionArobase = email.IndexOf('@');	//Compatible avec char
			int positionDot = email.IndexOf(".");       //Compatible avec string

			int firstnameLength = positionDot;			//La longueur de mon prénom correspond à la position du point (6)

			string firstname = email.Substring(0, firstnameLength);	//Je donne le point de départ et défini le nombre de caractères

			string lastname = email.Substring(positionDot + 1, positionArobase - positionDot -1);

			string domainName = email.Substring(positionArobase + 1);   //Je donne le point de départ, sans le nombre de caractères, me retourne tout les caractères après le point de départ.

			Console.WriteLine($"Prénom : {firstname}\nNom de famille : {lastname}\nNom de domaine : {domainName}");
		}
	}
}
