using System;
using System.Collections.Generic;

class Program
{
    static int totalPoints = 0;
    static Dictionary<string, string> items = new Dictionary<string, string>()
    {
        { "12345", "Pepsi Can - 10 Points" },
        { "67890", "Plastic Bottle - 5 Points" },
        { "11111", "Glass Bottle - 15 Points" },
        { "22222", "Cardboard Box - 8 Points" }
    };

    static Dictionary<string, int> points = new Dictionary<string, int>()
    {
        { "12345", 10 },
        { "67890", 5 },
        { "11111", 15 },
        { "22222", 8 }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Waste Rewards ===");
            Console.WriteLine("Total Points: " + totalPoints);
            Console.WriteLine("1. Scan Barcode");
            Console.WriteLine("2. Show Rewards");
            Console.WriteLine("3. Redeem Reward");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Barcode: ");
                string barcode = Console.ReadLine();

                if (points.ContainsKey(barcode))
                {
                    totalPoints += points[barcode];
                    Console.WriteLine("Great! You scanned: " + items[barcode]);
                    Console.WriteLine("Your total now: " + totalPoints);
                }
                else
                {
                    Console.WriteLine("This product is not registered!");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Rewards ---");
                Console.WriteLine("100 Points = Free Coffee");
                Console.WriteLine("300 Points = 20 EGP Credit");
                Console.WriteLine("500 Points = Cinema Ticket");
                Console.WriteLine("1000 Points = VIP Gift");
            }
            else if (choice == "3")
            {
                Console.Write("Enter points to redeem (100 / 300 / 500 / 1000): ");
                int need = Convert.ToInt32(Console.ReadLine());

                if (totalPoints >= need)
                {
                    totalPoints -= need;
                    Console.WriteLine("Congrats! You redeemed your reward!");
                    Console.WriteLine("Remaining Points: " + totalPoints);
                }
                else
                {
                    Console.WriteLine("Not enough points! Keep collecting.");
                }
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}
