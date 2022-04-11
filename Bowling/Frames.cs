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

        internal List<int>[] PlayAll()
        {
            List<int>[] scores = new List<int>[10];
            for (int i = 0; i < frames.Length; i++)
            {
                var roundScores = frames[i].Play();
                scores[i] = roundScores;
                scores[i].Add(roundScores.Sum());
                if (i > 0 && IsSpare(scores[i - 1]))
                {
                    scores[i - 1][^1] += scores[i][0];
                }
                else if (i > 0 && IsStrike(scores[i - 1]))
                {
                    scores[i - 1][^1] += (scores[i][0] + scores[i][1]); // incorrect: will throw exception if two strikes in a row occur
                }
            }
            return scores;
        }

        private bool IsStrike(List<int> list)
        {
            return list[0] == 10;
        }

        private static bool IsSpare(List<int> list)
        {
            return list.Count == 3 && list[0] + list[1] == 10;
        }
    }
}
