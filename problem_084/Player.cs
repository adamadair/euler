using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Player
    {
        private static MTRandom rng = new MTRandom();        
        public int Index { get; set; }
        public int DoubleCount { get; set; }

        public int RollDice(int sides)
        {
            var die1 = rng.Next(sides) + 1;
            var die2 = rng.Next(sides) + 1;
            if (die1 == die2) { ++DoubleCount; }
            else DoubleCount = 0;
            return die1 + die2;
        }
    }
}
