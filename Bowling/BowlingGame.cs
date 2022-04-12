namespace Bowling
{
    internal class BowlingGame
    {
        private readonly FramesWithScores _frames = new();

        internal void Play()
        {
            var frames = _frames.GetAll();
            for (int i = 0; i < frames.Length; i++)
            {
                Console.Write($"Frame {i + 1}:\t");
                for (int j = 0; j < frames[i].Item1.Count; j++)
                {
                    Console.Write($"Roll {j + 1}: {frames[i].Item1[j]}\t");

                }
                Console.Write($"Round total: {frames[i].Item2}");
                Console.WriteLine();
            }
            Console.WriteLine($"Final Score: {frames.Select(x => x.Item2).Sum()}");

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.Write($"Frame {i + 1}:\t");
            //    for (int j = 0; j < scores[i].Count; j++)
            //    {
            //        if (j < scores[i].Count - 1)
            //        {
            //            Console.Write($"Roll {j + 1}: {scores[i][j]}\t");
            //        }
            //        else
            //        {
            //            Console.Write($"Round total: {scores[i][j]}\t");
            //            finalScore += scores[i][j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Final score: {finalScore}");

        }
    }
}
