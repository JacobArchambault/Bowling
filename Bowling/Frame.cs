using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class Frame
    {
        int pins = 10;
        int turns;
        internal Frame(int turns)
        {
            this.turns = turns;
        }

        internal Frame() : this(2) { }

        internal void Play()
        {
            
        }
    }
}
