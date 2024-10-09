namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dans quel pays résidez-vous?");
            string country = Console.ReadLine();
            /*
            string resident = (country.ToLower() == "belgique") ? "belge" : 
                              (country.ToLower() == "france") ? "français(e)" : 
                              (country.ToLower() == "suisse") ? "suisse" : "autre";*/

            string resident = country.ToLower() switch
            {
                "belgique" => "belge",
                "france" => "français(e)",
                "suisse" => "suisse",
                _ => "autre"
            };
        }
    }
}
