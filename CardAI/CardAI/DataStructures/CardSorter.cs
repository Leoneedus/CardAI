using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAI.DataStructures
{
    public class CardSorter : Comparer<Card>
    {
        public override int Compare(Card x, Card y)
        {
            if (x.Colour.CompareTo(y.Colour) != 0)
            {
                return x.Colour.CompareTo(y.Colour);
            }
            else if (x.Sign.CompareTo(y.Sign) != 0)
            {
                return x.Sign.CompareTo(y.Sign);
            }
            else
            {
                return 0;
            }
        }
    }
}
