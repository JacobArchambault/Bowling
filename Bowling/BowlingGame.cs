using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class BowlingGame
    {
        private readonly Frame[] frames = new Frame[10]
        {
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(),
            new Frame(3)
        };

        private int score = 0;

        internal void Play()
        {
            for (int i = 0; i < frames.Length; i++)
            {
                Console.Write($"Frame {i + 1}:\t");
                var scores = frames[i].Play();
                for (int j = 0; j < scores.Count(); j++)
                {
                    Console.Write($"Roll {j+1}: {scores[j]}\t");
                }
                score += scores.Sum();
                Console.WriteLine($"Current score: {score}");
            }
        }
    }
}
