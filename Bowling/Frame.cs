using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class Frame
    {
        private int pins = 10;
        private int turns;
        private List<int> scores = new();
        internal Frame(int turns)
        {
            this.turns = turns;
        }

        internal Frame() : this(2) { }

        internal List<int> Play()
        {
            for (int i = 0; i < turns; i++)
            {
                var pinsKnockedDown = new Random().Next(pins + 1);
                pins -= pinsKnockedDown;
                scores.Add(pinsKnockedDown);
                if (pins == 0 && i == 0)
                {
                    i = turns; // ensures that on a normal frame, if a player gets a strike, they don't get another turn.
                }
            };
            return scores;
        }
    }
}
