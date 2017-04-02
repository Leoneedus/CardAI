using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.DataStructures
{
    class Deck
    {
        List<Card> cards = new List<Card>();

        public List<Card> Cards
        { 
            get { return cards; }
        }

        public Deck()
        {
            var signs = Enum.GetValues(typeof(Sign));
            var colours = Enum.GetValues(typeof(Colour));

            foreach (Sign sign in signs)
                foreach (Colour colour in colours)
                    cards.Add(new Card(sign, colour));
        }

        public override string ToString()
        {
            string text = "";
            for(int i = 0; i < cards.Count; i++)
            {
                text += cards[i].ToString() + "    ";
                if ((i + 1) % 4 == 0)
                    text += "\n";
            }
            return text;
        }
    }
}
