namespace Bowling
{
    internal class Frame
    {
        private int pins = 10;
        private readonly int turns;
        internal Frame(int turns)
        {
            this.turns = turns;
        }

        internal Frame() : this(2) { }

        internal List<int> Play()
        {
            List<int> scores = new();
            for (int i = 0; i < turns; i++)
            {
                var pinsKnockedDown = new Random().Next(pins + 1);
                pins -= pinsKnockedDown;
                scores.Add(pinsKnockedDown);
                if (pins == 0 && i == 0)
                {
                    i = turns; // ensures that on a normal frame, if a player gets a strike, they don't get another turn.
                }
            };
            return scores;
        }
    }
}
