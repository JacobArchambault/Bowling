﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class BowlingGame
    {
        private readonly Frame[] frames = new Frame[10];
        private int score = 0;

        internal void Play()
        {
            for (int i = 1; i <= frames.Length; i++)
            {
                Console.WriteLine($"Frame {i}:");
                frames[0].Play();
            }
        }
    }
}
