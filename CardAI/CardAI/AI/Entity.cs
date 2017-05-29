using CardAI.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.AI
{
    class Entity
    {
        string name;
        List<Card> hand = new List<Card>();
        List<Card> collected = new List<Card>();

        public List<Card> Hand
        {
            get { return hand; }
        }

        public Entity(string name)
        {
            this.name = name;
        }

        public void PrintHand()
        {
            Console.WriteLine(name);
            foreach (Card card in Hand)
                Console.Write(card.ToString() + " | ");
        }

        public void SortHand()
        {
            hand.Sort(new CardSorter());
            //hand = hand.OrderBy(s => s.Colour).ThenBy(s => s.Sign);
        }
    }
}
