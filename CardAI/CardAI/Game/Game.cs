using CardAI.AI;
using CardAI.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.Game
{
    class Game
    {
        Deck deck;
        List<Entity> players = new List<Entity>();
        public Colour? Favour;


        public Game()
        {
            deck = new Deck();
            for(int i = 0; i < 4; i++)
            {
                players.Add(new Entity("player_" + i));
            }
        }

        public void Run()
        {
            Console.Write(deck.ToString());
            deck.Cards.Shuffle();
            Console.WriteLine();
            HandOutCards();
            Console.Write(deck.ToString());
            foreach (Entity player in players)
            {
                Console.WriteLine();
                Console.WriteLine(player.Name);
                player.SortHand();
                player.PrintHand();
            }
            Console.ReadKey();
        }

        private void HandOutCards()
        {
            for (int i = 0; i < deck.Cards.Count - 3; i++)
            {
                deck.Cards[i].Owner = players[i % 3];
                players[i % 3].Hand.Add(deck.Cards[i]); 
            }

            for (int i = deck.Cards.Count - 3; i < deck.Cards.Count; i++)
            {
                players[3].Hand.Add(deck.Cards[i]);
            }
        }

        private void Auction()
        {

        }
    }
}
