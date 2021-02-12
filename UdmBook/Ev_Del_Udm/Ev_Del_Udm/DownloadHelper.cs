using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ev_Del_Udm
{
    class DownloadHelper
    {
        // Step 1 - create a delegate
        public delegate void FileDownloadedEventHandler(object source, EventArgs args);

        // Step 2 - create an event based on that delegate
        public event FileDownloadedEventHandler FileDownloaded;

        // Step 3 - raise the event
        protected virtual void OnFileDownloaded()
        {
            if(FileDownloaded != null)
            {
                FileDownloaded(this, EventArgs.Empty);
            }
        }


        public void Download(File File)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            // Step 3.1
            OnFileDownloaded();
        }
    }
}
