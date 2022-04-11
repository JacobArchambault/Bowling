namespace Bowling
{
    internal class BowlingGame
    {
        private readonly Frames _frames = new();

        internal void Play()
        {
            var scores = _frames.PlayAll();
            var finalScore = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Frame {i + 1}:\t");
                for (int j = 0; j < scores[i].Count; j++)
                {
                    if (j < scores[i].Count - 1)
                    {
                        Console.Write($"Roll {j + 1}: {scores[i][j]}\t");
                    }
                    else
                    {
                        Console.Write($"Round total: {scores[i][j]}\t");
                        finalScore += scores[i][j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Final score: {finalScore}");

        }
    }
}
