﻿using CardAI.AI;
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

        public Game()
        {
            deck = new Deck();
            for(int i = 0; i < 4; i++)
            {
                players.Add(new Entity());
            }
        }

        public void Run()
        {
            Console.Write(deck.ToString());
            deck.Cards.Shuffle();
            Console.WriteLine();
            HandOutCards();
            Console.Write(deck.ToString());
            Console.ReadKey();
        }

        private void HandOutCards()
        {
            for (int i = 0; i < deck.Cards.Count - 3; i++)
            {
                players[i % 3].Hand.Add(deck.Cards[i]); 
            }

            for (int i = deck.Cards.Count - 3; i < deck.Cards.Count; i++)
            {
                players[3].Hand.Add(deck.Cards[i]);
            }
        }
    }
}