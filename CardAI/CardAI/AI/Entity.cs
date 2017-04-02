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
        List<Card> hand = new List<Card>();

        public List<Card> Hand
        {
            get { return hand; }
        }

        public Entity()
        {

        }
    }
}
