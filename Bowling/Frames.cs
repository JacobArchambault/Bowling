﻿using System;
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
                scores[i].Add(roundScores.Sum());
                //scores[i] = roundScores.Sum();
                //Console.WriteLine();
            }
            return scores;
        }
    }
}
