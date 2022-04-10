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
                pins -= pinsKnockedDown;
                frameScore += pinsKnockedDown;
                if (pins == 0)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("You got a strike!");
                    }
                    else
                    {
                        Console.WriteLine("You got a spare!");
                    }
                }
                else
                {
                    Console.WriteLine($"You knocked down {pinsKnockedDown} pins!");
                }
            };
            return frameScore;
        }
    }
}
