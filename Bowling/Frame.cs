﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class Frame
    {
        int pins = 10;
        int turns;
        internal Frame(int turns)
        {
            this.turns = turns;
        }

        internal Frame() : this(2) { }

        internal int Play()
        {
            int frameScore = 0;
            for (int i = 0; i < turns; i++)
            {
                Console.WriteLine($"Turn {i + 1}:");
                var pinsKnockedDown = new Random().Next(pins + 1);
                Console.WriteLine($"You knocked down {pinsKnockedDown} pins!");
                pins -= pinsKnockedDown;
                frameScore += pinsKnockedDown;
            };
            return frameScore;
        }
    }
}
