using System;

namespace IntfUmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notifcation1 = new Notification("Denis", "hey dude, what is up?", "07-02-2018");
            Notification notifcation2 = new Notification("Stefan", "Hey not much :)", "07-02-2018");

            notifcation1.showNotification();
            notifcation2.showNotification();
        }
    }
}
