using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Commu.Components.Controls
{
    class LollipopXListBox : Panel
    {
        public enum MessageAlignment
        {
            Right,
            Left
        }

        int row = 3;
        public LollipopXListBox()
        {
            AutoScroll = true;
            HorizontalScroll.Visible = false;
        }

        public void Add(LollipopMessage Message,MessageAlignment Align)
        {
            Controls.Add(Message);
            if (Align == MessageAlignment.Left)
            {
                if (Message.Width > (Width / 2))
                {
                    Message.Width = (Width / 2);
                }
                Message.Left = 2;
            }
            else
            {
                if (Message.Width > (Width / 2))
                {
                    Message.Width = (Width / 2);
                    Message.Left = (Width / 2) - 5;
                }
                else
                {
                    Message.Left = Width - Message.Width;
                }
            }

            int h = (Message.Text.Length / (Message.Width / 7) * 30);

            if (h == 0)
            {
                row += 35;
            }
            else if (h == 30)
            {
                row += 60;
            }
            else if (h >= 31)
            {
                row += h + (10 - (h / 10));
            }
            Message.Location = new Point(Message.Left, row);
            VerticalScroll.Value = VerticalScroll.Maximum;
            Message.Visible = true;
        }
    }
}
