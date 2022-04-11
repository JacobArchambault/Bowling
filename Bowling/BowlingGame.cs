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
        private int[] scores = new int[10];

        internal void Play()
        {
            for (int i = 0; i < frames.Length; i++)
            {
                Console.Write($"Frame {i + 1}:\t");
                var roundScores = frames[i].Play();
                for (int j = 0; j < roundScores.Count(); j++)
                {
                    Console.Write($"Roll {j + 1}: {roundScores[j]}\t");
                }
                scores[i] = roundScores.Sum();
                Console.Write($"Round total: {scores[i]}");
                Console.WriteLine();
            }
        }
    }
}
