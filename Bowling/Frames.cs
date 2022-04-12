using Bowling.Interfaces;

namespace Bowling
{
    internal class Frames
    {
        private readonly IFrame[] frames = new IFrame[10]
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
            new FinalFrame()
        };

        internal List<int>[] PlayAll()
        {
            List<int>[] scores = new List<int>[10];
            for (int i = 0; i < frames.Length; i++)
            {
                scores[i] = frames[i].Play();
            }
            return scores;
        }

    }
}
