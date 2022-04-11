namespace Bowling
{
    internal class BowlingGame
    {
        private readonly Frames _frames = new();

        internal void Play()
        {
            _frames.Play();
        }
    }
}
