using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SchOolCsHaRp
{
    public delegate void TimerEvent(object sender, EventArgs e);
    class ClockTimer
    {
        public event TimerEvent Timer;

        public void Start()
        {
            for(int i = 0; i < 5; i++)
            {
                Timer(this, null);
                Thread.Sleep(1000);
            }
        }
    }
}
