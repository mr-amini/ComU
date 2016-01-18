namespace Commu
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectbtn = new LollipopButton();
            this.tmessage = new LollipopTextBox();
            this.lollipopSmallCard1 = new LollipopSmallCard();
            this.tphoto = new LollipopFileInput();
            this.lollipopLabel2 = new LollipopLabel();
            this.startbtn = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.tport = new LollipopTextBox();
            this.tname = new LollipopTextBox();
            this.tip = new LollipopTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tphoto);
            this.panel1.Controls.Add(this.lollipopLabel2);
            this.panel1.Controls.Add(this.startbtn);
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Controls.Add(this.tport);
            this.panel1.Controls.Add(this.tname);
            this.panel1.Controls.Add(this.tip);
            this.panel1.Location = new System.Drawing.Point(654, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 253);
            this.panel1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(542, 485);
            this.listBox1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Commu.Properties.Resources.attach11;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(493, 572);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Commu.Properties.Resources.mic1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(527, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // connectbtn
            // 
            this.connectbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.connectbtn.ButtonBackColor = System.Drawing.Color.MediumSeaGreen;
            this.connectbtn.ButtonFadeMotionColor = System.Drawing.Color.Black;
            this.connectbtn.ButtonFont = new System.Drawing.Font("Tahoma", 10F);
            this.connectbtn.ButtonMotionSpeed = 15;
            this.connectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectbtn.FontColor = System.Drawing.Color.White;
            this.connectbtn.Location = new System.Drawing.Point(429, 12);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(125, 52);
            this.connectbtn.TabIndex = 9;
            this.connectbtn.Text = "Connect";
            this.connectbtn.Click += new System.EventHandler(this.lollipopButton2_Click);
            // 
            // tmessage
            // 
            this.tmessage.Caption = "You are Disconnect";
            this.tmessage.CaptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmessage.CaptionForceColor = System.Drawing.Color.Gray;
            this.tmessage.FocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.tmessage.FontColor = System.Drawing.Color.Gray;
            this.tmessage.HelpTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmessage.HelpTextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tmessage.IsEnabled = false;
            this.tmessage.LineColor = System.Drawing.Color.Silver;
            this.tmessage.Location = new System.Drawing.Point(12, 572);
            this.tmessage.MaxLength = 32767;
            this.tmessage.MostComplete = false;
            this.tmessage.MostCompleteMessage = "This field is required";
            this.tmessage.Multiline = false;
            this.tmessage.Name = "tmessage";
            this.tmessage.PasswordChar = false;
            this.tmessage.ReadOnly = true;
            this.tmessage.Size = new System.Drawing.Size(475, 40);
            this.tmessage.TabIndex = 8;
            this.tmessage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tmessage.TextBoxBackColor = System.Drawing.Color.White;
            this.tmessage.TextBoxFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmessage.TextBoxInputType = LollipopTextBox.InputType.None;
            this.tmessage.TextBoxInputTypeMessage = "This field is string";
            this.tmessage.EnterPress += new LollipopTextBox.ButtonClickEvent(this.lollipopTextBox4_EnterPress);
            // 
            // lollipopSmallCard1
            // 
            this.lollipopSmallCard1.FontColor = "#33b679";
            this.lollipopSmallCard1.Image = null;
            this.lollipopSmallCard1.Info = "Info";
            this.lollipopSmallCard1.Location = new System.Drawing.Point(12, 12);
            this.lollipopSmallCard1.Name = "lollipopSmallCard1";
            this.lollipopSmallCard1.Size = new System.Drawing.Size(411, 52);
            this.lollipopSmallCard1.TabIndex = 7;
            this.lollipopSmallCard1.Text = "None";
            this.lollipopSmallCard1.ThumbnailColor = "#33b679";
            // 
            // tphoto
            // 
            this.tphoto.Filter = "All Files (*.*)|*.*";
            this.tphoto.FocusedColor = "#508ef5";
            this.tphoto.FontColor = "#999999";
            this.tphoto.IsEnabled = true;
            this.tphoto.Location = new System.Drawing.Point(397, 71);
            this.tphoto.MaxLength = 32767;
            this.tphoto.Name = "tphoto";
            this.tphoto.ReadOnly = false;
            this.tphoto.Size = new System.Drawing.Size(90, 24);
            this.tphoto.TabIndex = 6;
            this.tphoto.Text = "Your Photo";
            this.tphoto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tphoto.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(2, 26);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(507, 23);
            this.lollipopLabel2.TabIndex = 5;
            this.lollipopLabel2.Text = "To connection fill following Text box";
            this.lollipopLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.startbtn.ButtonBackColor = System.Drawing.Color.DeepSkyBlue;
            this.startbtn.ButtonFadeMotionColor = System.Drawing.Color.Black;
            this.startbtn.ButtonFont = new System.Drawing.Font("Tahoma", 10F);
            this.startbtn.ButtonMotionSpeed = 15;
            this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbtn.FontColor = System.Drawing.Color.White;
            this.startbtn.Location = new System.Drawing.Point(187, 198);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(143, 41);
            this.startbtn.TabIndex = 4;
            this.startbtn.Text = "Start";
            this.startbtn.Click += new System.EventHandler(this.lollipopButton1_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(3, 3);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(506, 23);
            this.lollipopLabel1.TabIndex = 3;
            this.lollipopLabel1.Text = "The computer is not connected with any computer.";
            this.lollipopLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tport
            // 
            this.tport.Caption = "Port";
            this.tport.CaptionFont = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tport.CaptionForceColor = System.Drawing.Color.Gray;
            this.tport.FocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.tport.FontColor = System.Drawing.Color.Gray;
            this.tport.HelpTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tport.HelpTextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tport.IsEnabled = true;
            this.tport.LineColor = System.Drawing.Color.Silver;
            this.tport.Location = new System.Drawing.Point(277, 132);
            this.tport.MaxLength = 32767;
            this.tport.MostComplete = true;
            this.tport.MostCompleteMessage = "This field is required";
            this.tport.Multiline = false;
            this.tport.Name = "tport";
            this.tport.PasswordChar = false;
            this.tport.ReadOnly = false;
            this.tport.Size = new System.Drawing.Size(210, 40);
            this.tport.TabIndex = 2;
            this.tport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tport.TextBoxBackColor = System.Drawing.Color.White;
            this.tport.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tport.TextBoxInputType = LollipopTextBox.InputType.None;
            this.tport.TextBoxInputTypeMessage = "This field is required";
            // 
            // tname
            // 
            this.tname.Caption = "Your Name";
            this.tname.CaptionFont = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.CaptionForceColor = System.Drawing.Color.Gray;
            this.tname.FocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.tname.FontColor = System.Drawing.Color.Gray;
            this.tname.HelpTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tname.HelpTextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tname.IsEnabled = true;
            this.tname.LineColor = System.Drawing.Color.Silver;
            this.tname.Location = new System.Drawing.Point(32, 73);
            this.tname.MaxLength = 32767;
            this.tname.MostComplete = true;
            this.tname.MostCompleteMessage = "This field is required";
            this.tname.Multiline = false;
            this.tname.Name = "tname";
            this.tname.PasswordChar = false;
            this.tname.ReadOnly = false;
            this.tname.Size = new System.Drawing.Size(360, 40);
            this.tname.TabIndex = 0;
            this.tname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tname.TextBoxBackColor = System.Drawing.Color.White;
            this.tname.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tname.TextBoxInputType = LollipopTextBox.InputType.None;
            this.tname.TextBoxInputTypeMessage = "This field is required";
            // 
            // tip
            // 
            this.tip.Caption = "Client IP";
            this.tip.CaptionFont = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.CaptionForceColor = System.Drawing.Color.Gray;
            this.tip.FocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.tip.FontColor = System.Drawing.Color.Gray;
            this.tip.HelpTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tip.HelpTextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tip.IsEnabled = true;
            this.tip.LineColor = System.Drawing.Color.Silver;
            this.tip.Location = new System.Drawing.Point(32, 132);
            this.tip.MaxLength = 32767;
            this.tip.MostComplete = true;
            this.tip.MostCompleteMessage = "This field is required";
            this.tip.Multiline = false;
            this.tip.Name = "tip";
            this.tip.PasswordChar = false;
            this.tip.ReadOnly = false;
            this.tip.Size = new System.Drawing.Size(206, 40);
            this.tip.TabIndex = 1;
            this.tip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip.TextBoxBackColor = System.Drawing.Color.White;
            this.tip.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tip.TextBoxInputType = LollipopTextBox.InputType.None;
            this.tip.TextBoxInputTypeMessage = "This field is required";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 624);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.tmessage);
            this.Controls.Add(this.lollipopSmallCard1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComU - Server";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopTextBox tname;
        private LollipopTextBox tip;
        private System.Windows.Forms.Panel panel1;
        private LollipopButton startbtn;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox tport;
        private LollipopLabel lollipopLabel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LollipopSmallCard lollipopSmallCard1;
        private LollipopFileInput tphoto;
        private LollipopTextBox tmessage;
        private LollipopButton connectbtn;
    }
}

