using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SchOolCsHaRp
{
    public delegate void TimerEvent(object sender, ClockTimerArgs e);
    class ClockTimer
    {
        public event TimerEvent Timer;

        public void Start()
        {
            for(int i = 0; i < 5; i++)
            {
                Timer(this, new ClockTimerArgs(i+1));
                Thread.Sleep(1000);
            }
        }
    }
}
