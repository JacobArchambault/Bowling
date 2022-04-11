using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class Frames
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

        internal List<int>[] Play()
        {
            List<int>[] scores = new List<int>[10];
            for (int i = 0; i < frames.Length; i++)
            {
                var roundScores = frames[i].Play();
                scores[i] = roundScores;
                //for (int j = 0; j < roundScores.Count(); j++)
                //{
                //    //Console.Write($"Roll {j + 1}: {roundScores[j]}\t");
                //}
                //scores[i] = roundScores.Sum();
                //Console.Write($"Round total: {scores[i]}");
                //Console.WriteLine();
            }
            return scores;
        }
    }
}
