﻿namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello les Wad!");
            Console.Write("\tComment vous nommez-vous ?");
            string? userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Bonjour {userName}!\nIl est actuellement {DateTime.Now.ToShortTimeString()}");

        }
    }
}