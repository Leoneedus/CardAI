using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.DataStructures
{
    class Card
    {
        Sign sign;
        Colour colour;
        int value;

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

        public Card(Sign sign, Colour colour)
        {
            this.sign = sign;
            this.colour = colour;
            value = (int)sign;
        }

        public override string ToString()
        {
            string text;
            text = sign.ToString() + " " + colour.ToString();
            return text;
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
