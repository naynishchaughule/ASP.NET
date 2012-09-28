using System;
using System.Collections.Generic;
using System.Text;

namespace NextDay
{
    class ButtonEvent : EventArgs
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ButtonEvent(int id)
        {
            Id = id;
        }
    }
}
