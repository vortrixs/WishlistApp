using System;
using System.Collections.Generic;

namespace WishlistApp
{
    class Program
    {
        private static List<Wish> Wishlist { get; set; }

        static void Main()
        {
            InitializeProgram();

            ProcessWishes(Console.ReadLine());

            Wishlist.Sort(
                (Wish wish1, Wish wish2) => wish1.Priority.CompareTo(wish2.Priority)
            );

            PrintWishlist();
        }

        private static void InitializeProgram()
        {
            Wishlist = new List<Wish>();

            Console.WriteLine("Input wishes as \"Item you wish for\", \"priority\" (1 being most wanted):");
        }
        
        private static void ProcessWishes(string input)
        {
            if (true == input.ToLower().Equals("#stop"))
            {
                return;
            }

            if (true == input.Contains(','))
            {
                AddWishToWishlist(input);
            }
            else
            {
                Console.WriteLine("Comma separator not found. Try again.");
            }

            ProcessWishes(Console.ReadLine());
        }

        private static void AddWishToWishlist(string input)
        {
            string[] wishSplit = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            string wishName = wishSplit[0];

            int wishPriority;

            try
            {
                wishPriority = int.Parse(wishSplit[1].Trim());
            }
            catch (FormatException)
            {
                Console.WriteLine("Priority needs to be a whole number. Try again.");
                return;
            }

            Wishlist.Add(
                new Wish(wishName, wishPriority)
            );
        }

        private static void PrintWishlist()
        {
            Console.WriteLine("\nPrinting Wishlist:");

            foreach (Wish item in Wishlist)
            {
                Console.WriteLine($"Wish: {item.Name} | Priority: {item.Priority}");
            }
        }
    }
}
