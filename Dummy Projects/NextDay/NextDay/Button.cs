using System;
using System.Collections.Generic;
using System.Text;

namespace NextDay
{
    delegate void Click(System.Object obj, EventArgs e, string msg);
    class Button
    {
        public event Click eve;

        public void RaiseEvent()
        {
            eve.Invoke(this, new ButtonEvent(48090), "hello world");
        }
    }
}
