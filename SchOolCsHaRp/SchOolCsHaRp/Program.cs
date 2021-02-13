using System;

namespace SchOolCsHaRp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockTimer clockTimer = new ClockTimer();
            //clockTimer.Timer += new TimerEvent(onClockTick);
            clockTimer.Start();
        }
        /*
        public static void onClockTick(object sender, EventArgs e)
        {
            Console.WriteLine("Recived a clock tick event...");
        }*/


    }
}
