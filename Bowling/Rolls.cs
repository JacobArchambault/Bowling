using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class Rolls
    {
        private int pins = 10;
        private readonly int turns;
        internal Rolls(int numberOfRolls)
        {
            this.turns = numberOfRolls;
        }

        internal Rolls() : this(2) { }

        public IEnumerable<int> Play()
        {
            int[] scores = new int[turns];
            for (int i = 0; i < turns; i++)
            {
                var pinsKnockedDown = new Random().Next(pins + 1);
                pins -= pinsKnockedDown;
                scores[i] = pinsKnockedDown;
                if (pins == 0 && i == 0)
                {
                    i = turns; // ensures that on a normal frame, if a player gets a strike, they don't get another turn.
                }
            };
            return scores;
        }
    }
}
