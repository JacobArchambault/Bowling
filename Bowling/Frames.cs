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
            new Frame()
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
