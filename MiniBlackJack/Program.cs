using System;

namespace MiniBlackJack
{
    class Program
    {
        private static Deck deck = new Deck();
        private static Game game = new Game();
        private static int points;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mini-BlackJack.");
            Console.WriteLine("Easy rules, to win you need to collect from 18 to 21.");
            Console.WriteLine("If you want to start press 'Enter'.");
            Console.ReadLine();
            game.DrawCard(deck);//get card to the list(hand)
            game.DrawCard(deck);
            points = game.GetValue();//return value
            Console.WriteLine("Your points are: " + points);
            Console.WriteLine("Do you want one more card? y/n");
            string firstAnswer = Console.ReadLine();
            if (firstAnswer == "y")
            {
                game.DrawCard(deck);
                points = game.GetValue();
                Console.WriteLine("Your points are: " + points);
                if (points > 21)
                {
                    Console.WriteLine("Too much points, try another time.");
                    return;
                }
                Console.WriteLine("Maybe another one?");
                string secondAnswer = Console.ReadLine();
                if (secondAnswer == "y")
                {
                    game.DrawCard(deck);
                    points = game.GetValue();
                    Console.WriteLine("Your points are: " + points);
                    if (points > 21)
                    {
                        Console.WriteLine("Too much points, try another time.");
                        return;
                    }
                    Console.WriteLine("One more, are you sure??");
                    string thirdAnswer = Console.ReadLine();
                    if (thirdAnswer == "y")
                    {
                        game.DrawCard(deck);
                        points = game.GetValue();
                        Console.WriteLine("Your points are: " + points);
                        if (points > 21)
                        {
                            Console.WriteLine("Too much points, try another time.");
                            return;
                        }
                        game.ShowResult();
                    }
                    else if (thirdAnswer == "n")
                    {
                        Console.WriteLine("Your points are: " + points);
                        if (points > 21)
                        {
                            Console.WriteLine("Too much points, try another time.");
                            return;
                        }
                        game.ShowResult();
                    }
                }
                else if (secondAnswer == "n")
                {
                    Console.WriteLine("Your points are: " + points);
                    if (points > 21)
                    {
                        Console.WriteLine("Too much points, try another time.");
                        return;
                    }
                    game.ShowResult();
                }
            }
            else if (firstAnswer == "n")
            {
                Console.WriteLine("Your points are: " + points);
                if (points > 21)
                {
                    Console.WriteLine("Fucking looser.");
                    return;
                }
                game.ShowResult();
            }
        }
    }
}
