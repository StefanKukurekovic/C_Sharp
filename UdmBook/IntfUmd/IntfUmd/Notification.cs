using System;
using System.Collections.Generic;
using System.Text;

namespace IntfUmd
{
    class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        public Notification()
        {
            sender = "Admin";
            message = "Yo, whats up";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void showNotification()
        {
            Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
        }
        public string getDate()
        {
            return date;
        }
    }
}
