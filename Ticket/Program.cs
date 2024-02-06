using System;

namespace Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, nik, telp, vaccineCard, address;
            Console.WriteLine("Welcome to the Ticket Booking Application");
            Console.WriteLine("+=======================================+");
            Console.Write("Input your name: ");
            name = Console.ReadLine();
            Console.Write("Input your NIK: ");
            nik = Console.ReadLine();
            Console.Write("Input your telepon number: ");
            telp = Console.ReadLine();
            Console.Write("Input your Vaccine Card: ");
            vaccineCard = Console.ReadLine();
            Console.Write("Input your address: ");
            address = Console.ReadLine();


            Console.WriteLine("\nThank you for ordering tickets!");
            Console.WriteLine("Here is your ordering information:");
            Console.WriteLine("=======================================");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("NIK: {0}", nik);
            Console.WriteLine("Telepon Number: {0}", telp);
            Console.WriteLine("Vaccine Card Number: {0}", vaccineCard);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}