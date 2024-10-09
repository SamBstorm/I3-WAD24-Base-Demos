namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez, s'il vous plait, introduire votre année de naissance :");
            string userInput = Console.ReadLine();
            int userBirthYear;
            //bool isConverted = int.TryParse(userInput, out userBirthYear);
            //if (isConverted)
            if(int.TryParse(userInput, out userBirthYear))
            {
                int yearsOld = DateTime.Now.Year - userBirthYear;
                if (yearsOld >= 18)
                {
                    Console.WriteLine("Veuillez indiquer votre pays de résidence :");
                    string country = Console.ReadLine();
                    /* //Version else if
                    if (country.ToLower() == "belgique")
                    {
                        Console.WriteLine("Bienvenue sur le site de la loterie nationale, une fois!");
                    }
                    else if (country.ToLower() == "france")
                    {
                        Console.WriteLine("Bienvenue sur le site de la loterie nationale, cocoricco!");
                    }
                    else if(country.ToLower() == "suisse")
                    {
                        Console.WriteLine("Bienvenueeeeeuhhhh sur le siteeeeeuhhhh de la loterieeeeeuhhhh nationaleeeeeuhhhh!");
                    }
                    else if (country.ToLower() == "canada")
                    {
                        Console.WriteLine("Bienvenue sur le site de la loterie nationale, tabernac!");
                    }
                    else
                    {
                        Console.WriteLine("Malheureusement, vous n'êtes pas né du bon côté de la frontière...");
                    }*/
                    //Version switch
                    switch (country.ToLower()) {
                        case "belgique":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale, une fois!");
                            break;
                        case "france":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale, cocoricco!");
                            break;
                        case "suisse":
                            Console.WriteLine("Bienvenueeeeeuhhhh sur le siteeeeeuhhhh de la loterieeeeeuhhhh nationaleeeeeuhhhh!");
                            break;
                        case "canada":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale, tabernac!");
                            break;
                        default:
                            Console.WriteLine("Malheureusement, vous n'êtes pas né du bon côté de la frontière...");
                            break;
                    }
                
                }
                else
                {
                    Console.WriteLine($"Reviens dans {18 - yearsOld} ans !");
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide...");
            }
        }
    }
}
