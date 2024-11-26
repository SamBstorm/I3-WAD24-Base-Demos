namespace Demo16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight feu_rouge = new TrafficLight();
            feu_rouge.color = TrafficLightColor.Green;
            Console.WriteLine($"Presently, the traffic light is {feu_rouge.color}.");
            feu_rouge.ChangeColor();
            Console.WriteLine($"Presently, the traffic light is {feu_rouge.color}.");
            feu_rouge.ChangeColor();
            Console.WriteLine($"Presently, the traffic light is {feu_rouge.color}.");
        }
    }
}
