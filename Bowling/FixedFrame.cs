namespace Bowling
{
    internal class FixedFrame
    {
        readonly Rolls _turns;

        public FixedFrame(Rolls turns)
        {
            _turns = turns;
        }

        internal Tuple<IEnumerable<int>, int> Play()
        {
            var turns = _turns.Play();
            return Tuple.Create(turns, turns.Sum());
        }
    }
}
