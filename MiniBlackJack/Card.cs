using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlackJack
{
    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
    public enum CardSuit
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds
    }
    public class Card
    {
        public int Value { get; set; }
        public CardSuit Suit { get; set; }
        public Rank Rank { get; set; }
        public Card(Rank rank, CardSuit suit, int value)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Value = value;
        }

    }

}

