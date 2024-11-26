namespace Demo18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voici la liste des couleurs de mon énumération :");
            #region Récupérer l'énumération en format string
            /* Exemple des slides :
                foreach (string couleur in Enum.GetNames(typeof(Couleurs)))
                {
                    Console.WriteLine(couleur);
                }*/

            /*OU*/

            foreach (string couleur in Enum.GetNames<Couleurs>())
            {
                Console.WriteLine(couleur);
            }
            #endregion


            #region Récupérer l'énumération en format de l'énumération
            /*Version non-générique
            foreach (Couleurs couleur in Enum.GetValues(typeof(Couleurs)))
            {
                Console.WriteLine(couleur);
            }*/
            /*OU*/
            foreach (Couleurs couleur in Enum.GetValues<Couleurs>())
            {
                Console.WriteLine(couleur);
            }
            #endregion

            #region Récupérer une énumération à partir d'un string
            Console.WriteLine("Quelle couleur aimez-vous ?");

            string userColor = Console.ReadLine();

            /*Version non-générique
            Couleurs couleurFavorite = (Couleurs)Enum.Parse(typeof(Couleurs), userColor);
            */

            /*OU*/

            /*Couleurs couleurFavorite = Enum.Parse<Couleurs>(userColor);*/

            Couleurs couleurFavorite;
            while (!Enum.TryParse<Couleurs>(userColor, out couleurFavorite))
            {
                Console.WriteLine($"La couleur \"{userColor}\" ne fait pas parti de la liste...");
                userColor = Console.ReadLine();
            }

            Console.WriteLine($"Votre couleur favorite est donc le {couleurFavorite}!"); 
            #endregion
        }
    }
}
