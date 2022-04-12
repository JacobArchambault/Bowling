using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class FramesWithScores
    {
        readonly Frames _frames = new();
        internal Tuple<List<int>, int>[] GetAll()
        {
            var frames = _frames.PlayAll();
            var scores = new List<int>();
            for (int i = 0; i < frames.Length; i++)
            {
                scores.Add(frames[i].Sum());
                if (i > 0 && IsSpare(frames[i - 1]))
                {
                    scores[i - 1] += frames[i][0];
                }
                else if (i > 0 && IsStrike(frames[i - 1]))
                {
                    if (frames[i].Count > 1)
                    {
                        scores[i - 1] += (frames[i][0] + frames[i][1]);
                    }
                    else
                    {
                        scores[i - 1] += frames[i][0] + frames[i + 1][0];
                    }
                }
            }
            return new Tuple<List<int>, int>[10]
            {
                new Tuple<List<int>, int>(frames[0], scores[0]),
                new Tuple<List<int>, int>(frames[1], scores[1]),
                new Tuple<List<int>, int>(frames[2], scores[2]),
                new Tuple<List<int>, int>(frames[3], scores[3]),
                new Tuple<List<int>, int>(frames[4], scores[4]),
                new Tuple<List<int>, int>(frames[5], scores[5]),
                new Tuple<List<int>, int>(frames[6], scores[6]),
                new Tuple<List<int>, int>(frames[7], scores[7]),
                new Tuple<List<int>, int>(frames[8], scores[8]),
                new Tuple<List<int>, int>(frames[9], scores[9])
            };
        }

        private static bool IsStrike(List<int> list)
        {
            return list[0] == 10;
        }

        private static bool IsSpare(List<int> list)
        {
            return list[0] != 10 && list.Sum() == 10;
        }

    }
}
