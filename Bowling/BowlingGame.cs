namespace Bowling
{
    internal class BowlingGame
    {
        private readonly Frames _frames = new();

        internal void Play()
        {
            var scores = _frames.Play();
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Frame {i + 1}:\t");
                for (int j = 0; j < scores[i].Count(); j++)
                {
                    Console.Write($"Roll {j + 1}: {scores[i][j]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
