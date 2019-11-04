using System;
using System.Collections.Generic;

namespace WishlistApp
{
    class WishList
    {
        private static readonly List<Wish> Wishlist = new List<Wish>();

        static void Main()
        {
            Console.WriteLine("Input wishes as \"Item you wish for\", \"priority\" (1 being most wanted):");

            StoreWish(Console.ReadLine());

            Wishlist.Sort(
                (Wish wish1, Wish wish2) => wish1.Priority.CompareTo(wish2.Priority)
            );

            Console.WriteLine("\nPrinting Wishlist:");

            foreach (Wish item in Wishlist)
            {
                Console.WriteLine($"Wish: {item.Name}. Priority: {item.Priority}");
            }
        }
        
        private static void StoreWish(string input)
        {
            if (true == input.Equals("#STOP"))
            {
                return;
            }

            if (true == input.Contains(','))
            {
                AddWish(input);
            }
            else
            {
                Console.WriteLine("Try again");
            }            

            StoreWish(Console.ReadLine());
        }

        private static void AddWish(string input)
        {
            string[] wishSplit = input.Split(",");

            string wishName = wishSplit[0];
            int wishPriority = int.Parse(wishSplit[1].Trim());

            Wishlist.Add(
                new Wish(wishName, wishPriority)
            );
        }
    }
}
