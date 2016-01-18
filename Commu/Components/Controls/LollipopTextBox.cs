using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[DefaultEvent("TextChanged")]
public class LollipopTextBox : Control
{

    #region  Variables
    TextBox LollipopTB = new TextBox();
    Label LollipopLBL = new Label();
    Label LollipopCaptionLBL = new Label();


    HorizontalAlignment ALNType;
    InputType txtInputType = InputType.None;

    int maxchars = 32767;
    bool readOnly;
    bool previousReadOnly;
    bool multiline;
    bool isPasswordMasked = false;
    bool Enable = true;
    bool hiddenText = false;
    bool mostcomplete = false;

    Timer AnimationTimer = new Timer { Interval = 1 };

    FontManager font = new FontManager();
    Font captionfont = new Font("Roboto",9);
    Font textboxfont = new Font("Roboto Medium",10);
    bool Focus = false;

    float SizeAnimation = 0;
    float SizeInc_Dec;

    float PointAnimation;
    float PointInc_Dec;

    Color fontColor = Color.Gray;
    Color focusColor = Color.DeepSkyBlue;
    Color enablelinecolor = Color.Silver;
    Color Disablelinecolor = Color.Gainsboro;
    Color EnabledFocusedColor;
    Color EnabledStringColor;

    
    Color DisabledStringColor = ColorTranslator.FromHtml("#babbbd");

    string mostcompletemessage = "This field is required";

    public enum InputType
    {
        None,
        Numric,
        String,
        Alphabet,
        PersianAlphabet,

    };

    #endregion
    #region  Properties

    public ContentAlignment HelpTextAlignment
    {
        get { return LollipopLBL.TextAlign; }
        set { LollipopLBL.TextAlign = value; Invalidate(); }

    }

    public string MostCompleteMessage
    {
        get
        {
            return mostcompletemessage;
        }

        set
        {
            mostcompletemessage = value;
            Invalidate();
        }
    }

    public string TextBoxInputTypeMessage
    {
        get
        {
            return LollipopLBL.Text;
        }

        set
        {
            LollipopLBL.Text = value;
            Invalidate();
        }
    }

    public Font HelpTextFont
    {
        get
        {
            return LollipopLBL.Font;
        }

        set
        {
            LollipopLBL.Font = value;
            Invalidate();
        }
    }

    public Font CaptionFont
    {
        get
        {
            return captionfont;
        }

        set
        {
            captionfont = value;
            LollipopCaptionLBL.Font = captionfont;
            Invalidate();        
        }
    }

    public string Caption
    {
        get
        {
            return LollipopCaptionLBL.Text;
        }

        set
        {
            LollipopCaptionLBL.Text = value;
            Invalidate();
        }
    }


    public Color TextBoxBackColor
    {
        get
        {
            return LollipopTB.BackColor;
        }
        set
        {
            LollipopTB.BackColor = value;
            Invalidate();
        }
    }

    [Category("Behavior")]
    public bool MostComplete
    {
        get
        {
            return mostcomplete;
        }
        set
        {
            mostcomplete = value;

            if (MostComplete == true)
            {
                LollipopLBL.Visible = true;
                LollipopLBL.ForeColor = focusColor;
                LollipopLBL.Text = MostCompleteMessage;
            }
            else
            {
                LollipopLBL.Visible = false;
            }
            Invalidate();
        }
    }

    [Category("Behavior")]
    public InputType TextBoxInputType
    {
        get
        {
            return txtInputType;
        }
        set
        {
            txtInputType = value;
            if (txtInputType != InputType.None)
            {
                LollipopLBL.Text = TextBoxInputTypeMessage;
                LollipopLBL.Visible = true;
            }
            Invalidate();
        }
    }

    public HorizontalAlignment TextAlignment
    {
        get
        {
            return ALNType;
        }
        set
        {
            ALNType = value;
            Invalidate();
        }
    }

    [Category("Behavior")]
    public int MaxLength
    {
        get
        {
            return maxchars;
        }
        set
        {
            maxchars = value;
            LollipopTB.MaxLength = MaxLength;
            Invalidate();
        }
    }
    [Category("Behavior")]
    public bool Multiline
    {
        get
        {
            return multiline;
        }
        set
        {
            multiline = value;
            if (LollipopTB != null)
            {
                LollipopTB.Multiline = value;

                if (value)
                {
                    LollipopTB.Location = new Point(-3, 1);
                    LollipopTB.Width = Width + 3;
                    LollipopTB.Height = Height - 6;
                }
                else
                {
                    LollipopTB.Location = new Point(0, 1);
                    LollipopTB.Width = Width;
                    Height = 40;
                }
            }
        }
    }
    [Category("Behavior")]
    public bool PasswordChar
    {
        get
        {
            return isPasswordMasked;
        }
        set
        {
            LollipopTB.UseSystemPasswordChar = PasswordChar;
            isPasswordMasked = value;
            Invalidate();
        }
    }

    [Category("Behavior")]
    public bool ReadOnly
    {
        get
        {
            return readOnly;
        }
        set
        {
            readOnly = value;
            if (LollipopTB != null)
            {
                LollipopTB.ReadOnly = value;
            }
        }
    }

    [Category("Behavior")]
    public bool IsEnabled
    {
        get { return Enable; }
        set
        {
            Enable = value;

            if (IsEnabled)
            {
                readOnly = previousReadOnly;
                LollipopTB.ReadOnly = previousReadOnly;
                LollipopTB.ForeColor = EnabledStringColor;
            }
            else
            {
                previousReadOnly = ReadOnly;
                ReadOnly = true;
                LollipopTB.ForeColor = DisabledStringColor;
            }

            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color LineColor
    {
        get { return enablelinecolor; }
        set { enablelinecolor = value; Invalidate(); }
    }

    [Category("Appearance")]
    public Color CaptionForceColor
    {
        get { return LollipopCaptionLBL.ForeColor; }
        set
        {
            LollipopCaptionLBL.ForeColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color FocusedColor
    {
        get { return focusColor; }
        set
        {
            focusColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Color FontColor
    {
        get { return fontColor; }
        set
        {
            fontColor = value;
            Invalidate();
        }
    }


    [Browsable(false)]
    public bool Enabled
    {
        get { return base.Enabled; }
        set { base.Enabled = value; }
    }

    [Category("Appearance")]
    public Font TextBoxFont
    {
        get
        {
            return textboxfont;
        }

        set 
        {
            textboxfont = value;
            LollipopTB.Font = textboxfont;
            Invalidate();
        }
    }

    [Browsable(false)]
    public Color BackColor
    {
        get { return base.BackColor; }
        set {  }
    }

    [Browsable(false)]
    public Font Font
    {
        get { return base.Font; }
        set { }
    }

    [Browsable(false)]
    public Color ForeColor
    {
        get { return base.ForeColor; }
        set {}
    }

    #endregion
    #region  Events

    public delegate void ButtonClickEvent(object sender, EventArgs e);
    public event ButtonClickEvent EnterPress;

    void GotFocus(object sender, EventArgs e)
    {
        Focus = true;

        LollipopLBL.ForeColor = focusColor;
        if (LollipopCaptionLBL.Visible == true)
        {
            LollipopCaptionLBL.Visible = false;
            LollipopTB.Text = "";
        }
        
        AnimationTimer.Start();
        
    }

    void LostFocus(object sender, EventArgs e)
    {
        Focus = false;
        LollipopLBL.ForeColor = LollipopLBL.BackColor;
        if (MostComplete == true && LollipopTB.Text.Trim().ToString() == "")
        {
            LollipopLBL.ForeColor = Color.Red;
            LollipopLBL.Text = MostCompleteMessage;
        }
        
        if (LollipopTB.Text.Trim().ToString() == "")
        {
            LollipopCaptionLBL.Visible = true;
        }
        AnimationTimer.Start();
        
    }

    protected void OnKeyPress(object Obj, KeyPressEventArgs e)
    {
        // Enter Numeric Value
        if (txtInputType == InputType.Numric)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        // Enter String Value
        if (txtInputType == InputType.String)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        // Enter PersianAlphabet Value
        if (txtInputType == InputType.PersianAlphabet)
        {
            if (!(e.KeyChar >= 1574 && e.KeyChar <= 1740))
            {
               if (e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
        }
    }
    
    protected void OnKeyDown(object Obj, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.A)
        {
            LollipopTB.SelectAll();
            e.SuppressKeyPress = true;
        }
        if (e.Control && e.KeyCode == Keys.C)
        {
            LollipopTB.Copy();
            e.SuppressKeyPress = true;
        }
        if (e.Control && e.KeyCode == Keys.X)
        {
            LollipopTB.Cut();
            e.SuppressKeyPress = true;
        }
        if (e.Control && e.KeyCode == Keys.V)
        {
            LollipopTB.Paste();
            e.SuppressKeyPress = true;
        }

        if (e.KeyCode == Keys.Enter)
        {
            EnterPress(this, e);
            e.SuppressKeyPress = true;
        }


        // Enter Alphabet Value
        if (txtInputType == InputType.Alphabet)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode == Keys.Back || e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = false;
            }
        }
    }
    protected override void OnTextChanged(System.EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }

    protected override void OnGotFocus(System.EventArgs e)
    {
        base.OnGotFocus(e);
        LollipopTB.Focus();
        LollipopTB.SelectionLength = 0;
    }
    protected override void OnResize(System.EventArgs e)
    {
        base.OnResize(e);

        PointAnimation = Width / 2;
        SizeInc_Dec = Width / 15;
        PointInc_Dec = Width / 30;

        LollipopTB.Width = Width;
        LollipopCaptionLBL.Width = Width;


        if (multiline)
        {
            LollipopTB.Location = new Point(-3, 1);
            LollipopTB.Width = Width + 3;
            LollipopTB.Height = Height - 6;
        }
        else
        {
            LollipopTB.Location = new Point(0, 1);
            LollipopTB.Width = Width;
            Height = 40;
        }
    }

    #endregion

    #region Form
    public void AddLable()
    {
        LollipopLBL.Location = new Point(5, Height-18);
        LollipopLBL.Size = new Size(Width, 20);
        LollipopLBL.TextAlign = ContentAlignment.MiddleLeft;
        LollipopLBL.BackColor = Color.Transparent;
        LollipopLBL.ForeColor = LollipopLBL.BackColor;
        LollipopLBL.Font = captionfont;
        LollipopLBL.Text = "This field is string";

        LollipopCaptionLBL.Text = "TextBox";
        LollipopCaptionLBL.Location = new Point(0, 1);
        LollipopCaptionLBL.Size = new Size(Width, 20);
        LollipopCaptionLBL.TextAlign = ContentAlignment.MiddleCenter;
        LollipopCaptionLBL.Font = captionfont;
        LollipopCaptionLBL.BackColor = Color.Transparent;
        LollipopCaptionLBL.ForeColor = fontColor;
        LollipopCaptionLBL.Cursor = System.Windows.Forms.Cursors.IBeam;
        


    }

    public void AddTextBox()
    {
        LollipopTB.Location = new Point(0, 1);
        LollipopTB.Size = new Size(Width,20);

        LollipopTB.BackColor = Color.White;
        LollipopTB.BorderStyle = BorderStyle.None;
        LollipopTB.TextAlign = HorizontalAlignment.Center;
        LollipopTB.Font = textboxfont;
        LollipopTB.UseSystemPasswordChar = PasswordChar;
        LollipopTB.Multiline = false;
        LollipopTB.ScrollBars = ScrollBars.None;

        LollipopTB.KeyDown += OnKeyDown;
        LollipopTB.KeyPress += OnKeyPress;
        LollipopTB.GotFocus += GotFocus;
        LollipopTB.LostFocus += LostFocus;
        
    }



    public LollipopTextBox()
    {

        Width = 300;
        DoubleBuffered = true;

        AddLable();
        AddTextBox();

        Controls.Add(LollipopCaptionLBL);
        Controls.Add(LollipopLBL);
        Controls.Add(LollipopTB);

        LollipopCaptionLBL.Click += (sender, args) => LollipopTB.Select();
        LollipopTB.TextChanged += (sender, args) => Text = LollipopTB.Text;
        base.TextChanged += (sender, args) => LollipopTB.Text = Text;

        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        base.OnPaint(e);
        Bitmap B = new Bitmap(Width, Height);
        Graphics G = Graphics.FromImage(B);
        G.Clear(Color.Transparent);

        EnabledStringColor = fontColor;
        EnabledFocusedColor = focusColor;

        LollipopTB.TextAlign = TextAlignment;
        LollipopTB.ForeColor = IsEnabled ? EnabledStringColor : DisabledStringColor;
        LollipopTB.UseSystemPasswordChar = PasswordChar;

        G.DrawLine(new Pen(new SolidBrush(IsEnabled ? enablelinecolor : Disablelinecolor)), new Point(0, Height - 20), new Point(Width, Height - 20));
        if (IsEnabled)
        { G.FillRectangle(new SolidBrush(EnabledFocusedColor), PointAnimation, (float)Height - 20, SizeAnimation, 2); }

        e.Graphics.DrawImage((Image)(B.Clone()), 0, 0);
        G.Dispose();
        B.Dispose();
    }

    protected void AnimationTick(object sender, EventArgs e)
    {
        if (Focus)
        {
            if (SizeAnimation < Width)
            {
                SizeAnimation += SizeInc_Dec;

                this.Invalidate();
            }

            if (PointAnimation > 0)
            {
                PointAnimation -= PointInc_Dec;
                this.Invalidate();
            }
        }
        else
        {
            if (SizeAnimation > 0)
            {
                SizeAnimation -= SizeInc_Dec;
                this.Invalidate();
            }

            if (PointAnimation < Width / 2)
            {
                PointAnimation += PointInc_Dec;
                this.Invalidate();
            }
        }
    }
    #endregion
}
