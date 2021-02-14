using System;

namespace SchOolCsHaRp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockTimer clockTimer = new ClockTimer();
            clockTimer.Timer += new TimerEvent(onClockTick);
            clockTimer.Timer += new TimerEvent(onClockTickTwo);
            clockTimer.Timer -= new TimerEvent(onClockTickTwo);
            clockTimer.Start();
        }
        
        public static void onClockTick(object sender, ClockTimerArgs e)
        {
            Console.Clear();
            Console.WriteLine("{0}", e.TickCount);
            
        }

        public static void onClockTickTwo(object sender, EventArgs e)
        {
            Console.Clear();
        }


    }
}
