using CardAI.DataStructures;
using CardAI.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.AI
{
    public class Entity
    {
        string name;
        Table table;
        List<Card> hand = new List<Card>();
        List<Card> collected = new List<Card>();

        public string Name
        {
            get { return name; }
        }

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
        }

        protected void ThrowCard(Card card)
        {
            table.Heap.Add(card);
            hand.Remove(card);
        }

        protected void GrabCards()
        {
            collected.AddRange(table.Heap);
            table.Heap.Clear();
        }
    }
}
