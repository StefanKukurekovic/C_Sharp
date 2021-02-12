using System;
using System.Threading;

namespace Ev_Del_Udm
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper();
            var unpackService = new UnpackService();
            var unpacked = new Unpacked();
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += unpacked.UpackedMessage;

            downloadHelper.Download(file);
        }

        public class UnpackService
        {
            public void OnFileDownloaded(object source, EventArgs e)
            {
                Console.WriteLine("UnpackerService: Unpacking the file...");
                Thread.Sleep(4000);
            }
        }

        public class Unpacked
        {
            public void UpackedMessage(object source, EventArgs e)
            {
                Console.WriteLine("You have 1 Message.");
                Thread.Sleep(1000);
                Console.WriteLine("Unpacking message...");
                Thread.Sleep(4000);
                Console.WriteLine("Its a message from your future self, Stefan!");
                Thread.Sleep(4000);
                Console.WriteLine("Fuck you!");
                Thread.Sleep(4000);
            }
        }

    }
}
