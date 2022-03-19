using System;
using System.Collections.Generic;

namespace Cards
{
    public class Deck
    {
        private Stack<Card> deck { get; set; }
        private static Random r = new Random();
        public Deck()
        {
            deck = new Stack<Card>();
        }
        public void GenerateDeck()
        {
            deck.Clear();
            List<Card> cards = new List<Card>();
            int trumpNum = r.Next(0, 4);
            string trumpSuit = Card.GetSuit(trumpNum);

            Console.WriteLine($"{trumpSuit} is chosen to be a Trump card");
            for(int i = 0; i < 9; i++) // Name
            {
                for (int j = 0; j < 4; j++) // Suit
                {
                    bool isTrump = false;
                    if (trumpNum == j) isTrump = true;

                    Card card = new Card(i, j, isTrump);
                    cards.Add(card);
                }
            }
            Card[] cardArray = cards.ToArray();
            cardArray = Shuffle<Card>(cardArray);
            foreach(Card card in cardArray)
            {
                deck.Push(card);
                Console.WriteLine($"{card.GetName()}: {card.GetSuit()} [{card.IsTrump()}]");
            }
            
        }
        public static Card[] Shuffle<Card>(Card[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = r.Next(n);
                n--;
                Card temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            return array;
        }
    }
}
