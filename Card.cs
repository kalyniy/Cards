using System;
namespace Cards
{
    public class Card
    {
        private Names name { get; set; }
        private Suits suit { get; set; }

        private bool isTrump { get; set; }
        enum Names
        {
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        enum Suits
        {
            Hearts, // Черва
            Clubs, // Хреста
            Spades, // Піка
            Diamonds // Дзвуна

        }
        public Card()
        {
        }
        public Card(int name, int suit, bool isTrump)
        {
            this.name = (Names)name;
            this.suit = (Suits)suit;
            this.isTrump = isTrump;

        }
        public bool IsStronger(Card card)
        {
            if(this.isTrump && !card.isTrump)
            {
                return true;
            }
            else if(this.suit == card.suit && this.name > card.name) // if it is the same type and bigger
            {
                return true;
            }
            return false;
        }
        public bool IsTrump()
        {
            return this.isTrump;
        }
        public string GetName()
        {
            string retval = "";
            retval = Enum.GetName(typeof(Names), this.name);
            return retval;
        }
        public string GetSuit()
        {
            string retval = "";
            retval = Enum.GetName(typeof(Suits), this.suit);
            return retval;
        }
        public static string GetName(int name)
        {
            string retval = "";
            retval = Enum.GetName(typeof(Names), name);
            return retval;
        }
        public static string GetSuit(int suit)
        {
            string retval = "";
            retval = Enum.GetName(typeof(Suits), suit);
            return retval;
        }

    }
}
