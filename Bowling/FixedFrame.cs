using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class FixedFrame
    {
        private int pins = 10;
        private readonly int turns;
        internal FixedFrame(int turns)
        {
            this.turns = turns;
        }

        internal FixedFrame() : this(2) { }

        internal int[] Play()
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
