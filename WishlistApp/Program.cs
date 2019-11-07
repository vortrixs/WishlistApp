using System;
using System.Collections.Generic;

namespace WishlistApp
{
    class Program
    {
        private static List<Wish> Wishlist { get; set; }

        static void Main()
        {
            Wishlist = new List<Wish>();

            Console.WriteLine("Input wishes as \"Item you wish for\", \"priority\" (1 being most wanted):");

            StoreWish(Console.ReadLine());

            Wishlist.Sort(
                (Wish wish1, Wish wish2) => wish1.Priority.CompareTo(wish2.Priority)
            );

            Console.WriteLine("\nPrinting Wishlist:");

            foreach (Wish item in Wishlist)
            {
                Console.WriteLine($"Wish: {item.Name} | Priority: {item.Priority}");
            }
        }
        
        private static void StoreWish(string input)
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

            StoreWish(Console.ReadLine());
        }

        private static void AddWishToWishlist(string input)
        {
            string[] wishSplit = input.Split(",");

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
    }
}
