using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlackJack
{
    class Game
    {

        public int Value { get; set; }
        public Card CardFromDeck { get; set; }

        public List<Card> Hand = new List<Card>();
        private Card card;
        public void WriteDescription()
        {
            Console.WriteLine(Card.Rank + " " + Card.Suit + " " + Card.Value);
        }
        public Card Card
        {
            get { return card; }
            set { card = value; }
        }
        public void DrawCard(Deck deck)
        {
            Card = deck.getCard();
            WriteDescription();
            Value += Card.Value;
            Hand.Add(Card);
        }
        public void ShowResult()
        {
            if (Value < 18)
            {
                Console.WriteLine("It's not your day, you lost.");
            }
            else if (Value >= 18 && Value <= 21)
            {
                Console.WriteLine("Yay, you win, congratulations.");
            }
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
