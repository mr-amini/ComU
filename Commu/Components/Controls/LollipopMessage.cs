using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    class LollipopMessage : Control
    {
        FontManager font = new FontManager();
        Rectangle R;
        StringFormat sf = new StringFormat();

        #region Event

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
        }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);

    }

    protected override void OnMouseHover(EventArgs e)
    {
        base.OnMouseHover(e);
        Cursor = Cursors.Hand;
    }
    #endregion
    public LollipopMessage()
        {
            this.Font = font.Roboto_Medium10;
            SetStyle((ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint), true);
            DoubleBuffered = true;
            Size = new Size(150, 370);
            BackColor = Color.LightSeaGreen;
            ForeColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            R = new Rectangle(5, 10, Width - 5, Height - 10);

            int h = (Text.Length / (Width / 7) * 30);
            if (h == 0)
            {
                Height = 35;
            }
            else if (h == 30)
            {
                Height = 60;
            }
            else if (h >= 31)
            {
                Height = h + (10 - (h / 10));

            }

            var G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(Parent.BackColor);

            var BG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 3,3);
            Region region = new Region(BG);

            G.FillPath(new SolidBrush(Enabled ? BackColor : Color.White), BG);
            G.DrawPath(new Pen(Enabled ? BackColor : Color.White), BG);

            G.SetClip(region, CombineMode.Replace);

            G.DrawString(Text, Font, new SolidBrush(ForeColor), R, sf);
        }

    }
