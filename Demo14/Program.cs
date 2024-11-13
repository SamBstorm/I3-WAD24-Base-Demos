namespace Demo14
{
    public struct TempsHorloge
    {
        public const int HOURS_LIMIT = 23;
        public int hours;
        public int minutes;
        public int seconds;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int hours = 10;
            int minutes = 11;
            int seconds = 59;
            */

            TempsHorloge debutDemo;
            debutDemo.hours = 10;
            debutDemo.minutes = 11;
            debutDemo.seconds = 59;

            /*
            TempsHorloge finDemo = new TempsHorloge();  //Le mot clé new initialise toutes les variables internes à la structure avec leur valeur par défaut
            */



            /* Attention, si votre structure devient nullable, des testes complémentaires sont à prévoir...
            TempsHorloge? finDemo = null;
            finDemo = debutDemo;
            if (finDemo is not null)
            {
                TempsHorloge finDemoNotNull = (TempsHorloge)finDemo;
                finDemoNotNull.minutes = 30;
                finDemoNotNull.seconds = 00;
            }
            */

            TempsHorloge finDemo = debutDemo;
            finDemo.minutes = 30;
            finDemo.seconds = 00;

            Console.WriteLine($"La démonstration a commencé à {debutDemo.hours}:{debutDemo.minutes}:{debutDemo.seconds}");
            Console.WriteLine($"La démonstration s'est terminée à {finDemo.hours}:{finDemo.minutes}:{finDemo.seconds}");
        }
    }
}
