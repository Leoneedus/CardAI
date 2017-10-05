using CardAI.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.DataStructures
{
    public class Card : IComparable<Card>
    {
        private Sign sign;
        private Colour colour;
        private int value;
        private Entity owner;

        public int Value
        {
            get
            {
                return value;
            }
        }
        public Sign Sign
        {
            get
            {
                return sign;
            }
        }
        public Colour Colour
        {
            get
            {
                return colour;
            }
        }
        public Entity Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Card(Sign sign, Colour colour)
        {
            this.sign = sign;
            this.colour = colour;
            value = (int)sign;
            this.owner = owner;
        }

        public override string ToString()
        {
            string text;
            text = sign.ToString() + " " + colour.ToString();
            return text;
        }

        public int CompareTo(Card other)
        {
            if (this.sign.CompareTo(other.sign) != 0)
            {
                return this.sign.CompareTo(other.sign);
            }
            else if (this.colour.CompareTo(other.colour) != 0)
            {
                return this.colour.CompareTo(other.colour);
            }
            else
            {
                return 0;
            }
        }
    }

    public enum Sign
    {
        Nine = 0,
        Ten = 10,
        Jack = 2,
        Queen = 3,
        King = 4,
        Ace = 11
    }

    public enum Colour
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    
}
