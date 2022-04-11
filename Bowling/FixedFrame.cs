using Bowling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class FixedFrame
    {
        IPlayable _turns;

        public FixedFrame(IPlayable turns)
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
