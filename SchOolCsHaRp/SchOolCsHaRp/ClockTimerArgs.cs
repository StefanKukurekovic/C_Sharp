using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    public class ClockTimerArgs : EventArgs
    {
        private int tickCount;
        public ClockTimerArgs(int tickCount)
        {
            this.tickCount = tickCount;
        }

        public int TickCount
        {
            get { return tickCount; }
        }
    }
}
