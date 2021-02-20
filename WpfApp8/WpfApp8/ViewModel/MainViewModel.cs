using GalaSoft.MvvmLight;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;


namespace WpfApp8.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        static Random rand = new Random();
        private int randomNumber = 100;
        DispatcherTimer timer = new DispatcherTimer();

        public int RandomNumber
        {
            get { return randomNumber; }
            set { randomNumber = value; RaisePropertyChanged(); }
        }
        public MainViewModel()
        {
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RandomNumber = rand.Next(0,100);
        }
    }
}