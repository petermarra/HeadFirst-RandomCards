using System;
using System.Collections.Generic;

namespace RandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
                cards.Add(card);
                //cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            Console.WriteLine("Five random cards:");
            PrintCards(cards);

            CardComparer_byValue cardComparer = new CardComparer_byValue();
            cards.Sort(cardComparer);
            //cards.Sort(new CardComparer_byValue());

            Console.WriteLine("\r\nThose same cards sorted:");
            PrintCards(cards);
            
        }
        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
