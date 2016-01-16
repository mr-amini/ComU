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

public class LollipopFlatButton : Control
{

    #region  Variables

    Timer AnimationTimer = new Timer { Interval = 1 };

    FontManager font = new FontManager();
    StringFormat SF = new StringFormat();
    Rectangle R;

    bool Focus = false;

    int fadeCounter;
    int speed = 15;
    int xx;
    int yy;

    float SizeAnimation = 0;
    float SizeIncNum;
    float TempSizeIncNum;

    Color fontcolor = Color.Cyan ;

    Color EnabledBGColor;
    Color EnabledBorderColor;
    Color fadeColor = Color.Cyan ;


    Color DisabledStringColor = ColorTranslator.FromHtml("#969aa0");

    #endregion
    #region  Properties

    [Category("Appearance")]
    public Color FadeMotionColor
    {
        get { return fadeColor; }
        set
        {
            fadeColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public int MotionSpeed
    {
        get { return speed; }
        set
        {
            speed = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color FontColor
    {
        get { return fontcolor; }
        set
        {
            fontcolor = value;
            Invalidate();
        }
    }

    [Browsable(false)]
    public Font Font
    {
        get { return base.Font; }
        set { base.Font = value; }
    }

    [Browsable(false)]
    public Color ForeColor
    {
        get { return base.ForeColor; }
        set { base.ForeColor = value; }
    }

    #endregion
    #region  Events

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);

        EnabledBGColor = Color.FromArgb(30, fontcolor);
        EnabledBorderColor = Color.FromArgb(20, fontcolor);
        Refresh();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);

        EnabledBGColor = ColorTranslator.FromHtml("#ffffff");
        EnabledBorderColor = ColorTranslator.FromHtml("#ffffff");
        Refresh();
    }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        EnabledBGColor = Color.FromArgb(30, fontcolor);
        Refresh();

        xx = e.X;
        yy = e.Y;

        Focus = true;
        AnimationTimer.Start();
        Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        Invalidate();
    }

    protected override void OnTextChanged(System.EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        R = new Rectangle(0, 0, Width, Height);
    }

    #endregion

    public LollipopFlatButton()
    {
        SetStyle((ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint), true);
        DoubleBuffered = true;

        Size = new Size(143, 41);
        BackColor = Color.Transparent;

        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;

        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }

    protected override void OnResize(System.EventArgs e)
    {
        base.OnResize(e);
        SizeIncNum = Width / speed;
        TempSizeIncNum = SizeIncNum;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var G = e.Graphics;
        G.SmoothingMode = SmoothingMode.HighQuality;
        G.Clear(Parent.BackColor);

        var BG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 3, 1);
        Region region = new Region(BG);

        G.FillPath(new SolidBrush(Enabled ? EnabledBGColor : Color.White), BG);
        G.DrawPath(new Pen(Enabled ? EnabledBorderColor : Color.White), BG);

        G.SetClip(region, CombineMode.Replace);

        //The Ripple Effect
        G.FillEllipse(new SolidBrush(Color.FromArgb(fadeCounter, fadeColor)), xx - (SizeAnimation / 2), yy - (SizeAnimation / 2), SizeAnimation, SizeAnimation);
        
        G.DrawString(Text, font.Roboto_Medium10, new SolidBrush(Enabled? fontcolor :DisabledStringColor), R, SF);
    }

    protected void AnimationTick(object sender, EventArgs e)
    {
        if (Focus)
        {
            if (SizeAnimation < Width + 100)
            {
                SizeAnimation += SizeIncNum;
                fadeCounter = ((101 - ((int.Parse(SizeAnimation.ToString()) * 100) / (Width + 100))) / 3);
                SizeIncNum = ((int.Parse(TempSizeIncNum.ToString()) * (fadeCounter * 3)) / 100); if (SizeIncNum == 0) { SizeIncNum = 1; }
                this.Invalidate();
            }
            else
            {
                Focus = false;
                SizeAnimation = 0;
                SizeIncNum = TempSizeIncNum;
                fadeCounter = 100;
                this.Invalidate();
            }

        }
        else
        {
            if (SizeAnimation > 0)
            {
                SizeAnimation = 0;
                this.Invalidate();
            }
        }
    }
}