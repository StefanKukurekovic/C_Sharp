using System;
using System.Collections.Generic;
using System.Text;

namespace SchOolCsHaRp
{
    interface IWindow
    {
        Point Position { get; set; }
        string Title { get; set; }

        void Draw();
        void Minimize();
    }
}
