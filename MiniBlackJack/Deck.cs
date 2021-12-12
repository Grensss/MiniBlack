using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlackJack
{
    public class Deck
    {
        private Random rng = new Random();
        Dictionary<Rank, int> dict = new Dictionary<Rank, int>()
        {
            { Rank.Ace, 1 },
            { Rank.King, 10 },
            { Rank.Queen, 10 },
            { Rank.Jack, 10 },
            { Rank.Ten, 10 },
            { Rank.Nine, 9 },
            { Rank.Eight, 8 },
            { Rank.Seven, 7 },
            { Rank.Six, 6 },
            { Rank.Five, 5 },
            { Rank.Four, 4 },
            { Rank.Three, 3 },
            { Rank.Two, 2 }
        };

        public List<Card> deck = new List<Card>();

        public List<Card> shuffleddeck;
        public Deck()
        {
            Createdeck();
            Shuffle();
        }
        public List<Card> Createdeck()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card((Rank)i, (CardSuit)j, dict[(Rank)i]);
                    deck.Add(card);// adds cards in deck
                }
            }
            return deck;
        }
        public List<Card> Shuffle()
        {
            shuffleddeck = deck.OrderBy(a => rng.Next()).ToList();
            return shuffleddeck;
        }
        public Card getCard()
        {
            int index = rng.Next(0, shuffleddeck.Count - 1);
            var card = shuffleddeck[index];
            shuffleddeck.RemoveAt(index);
            return card;
        }
    }
}
