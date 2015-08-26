using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[4] { "Spades", "Diamonds", "Hearts", "Clubs" };
            string[] cards = new string[13] { "Ace of", "Two of", "Three of", "Four of", "Five of", "Six of", "Seven of", "Eight of", "Nine of", "Ten of", "Jack of", "Queen of", "King of" };

            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine(cards[j] + " " + colors[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
