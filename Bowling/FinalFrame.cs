using Bowling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class FinalFrame : IFrame
    {
        private int pins = 10;
        private int turns;
        internal FinalFrame(int turns)
        {
            this.turns = turns;
        }

        internal FinalFrame() : this(2) { }

        public List<int> Play()
        {
            List<int> scores = new();
            for (int i = 0; i < turns; i++)
            {
                var pinsKnockedDown = new Random().Next(pins + 1);
                pins -= pinsKnockedDown;
                scores.Add(pinsKnockedDown);
                if (pins == 0 && turns != 3)
                {
                    pins = 10;
                    turns = 3;
                }

            };
            return scores;
        }
    }
}
