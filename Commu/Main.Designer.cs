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
            this.lollipopFileInput1 = new LollipopFileInput();
            this.lollipopTextBox2 = new LollipopTextBox();
            this.lollipopTextBox1 = new LollipopTextBox();
            this.SuspendLayout();
            // 
            // lollipopFileInput1
            // 
            this.lollipopFileInput1.Filter = "All Files (*.*)|*.*";
            this.lollipopFileInput1.FocusedColor = "#508ef5";
            this.lollipopFileInput1.FontColor = "#999999";
            this.lollipopFileInput1.IsEnabled = true;
            this.lollipopFileInput1.Location = new System.Drawing.Point(336, 58);
            this.lollipopFileInput1.MaxLength = 32767;
            this.lollipopFileInput1.Name = "lollipopFileInput1";
            this.lollipopFileInput1.ReadOnly = false;
            this.lollipopFileInput1.Size = new System.Drawing.Size(300, 24);
            this.lollipopFileInput1.TabIndex = 2;
            this.lollipopFileInput1.Text = "lollipopFileInput1";
            this.lollipopFileInput1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopFileInput1.UseSystemPasswordChar = false;
            this.lollipopFileInput1.TextChanged += new System.EventHandler(this.lollipopFileInput1_TextChanged);
            // 
            // lollipopTextBox2
            // 
            this.lollipopTextBox2.Caption = "TextBox";
            this.lollipopTextBox2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lollipopTextBox2.CaptionForceColor = System.Drawing.Color.Gray;
            this.lollipopTextBox2.FocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.lollipopTextBox2.FontColor = System.Drawing.Color.Gray;
            this.lollipopTextBox2.HelpTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lollipopTextBox2.HelpTextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lollipopTextBox2.IsEnabled = true;
            this.lollipopTextBox2.LineColor = System.Drawing.Color.Silver;
            this.lollipopTextBox2.Location = new System.Drawing.Point(336, 12);
            this.lollipopTextBox2.MaxLength = 32767;
            this.lollipopTextBox2.MostComplete = false;
            this.lollipopTextBox2.MostCompleteMessage = "This field is required";
            this.lollipopTextBox2.Multiline = false;
            this.lollipopTextBox2.Name = "lollipopTextBox2";
            this.lollipopTextBox2.PasswordChar = false;
            this.lollipopTextBox2.ReadOnly = false;
            this.lollipopTextBox2.Size = new System.Drawing.Size(300, 40);
            this.lollipopTextBox2.TabIndex = 1;
            this.lollipopTextBox2.Text = "lollipopTextBox2";
            this.lollipopTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox2.TextBoxBackColor = System.Drawing.Color.White;
            this.lollipopTextBox2.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopTextBox2.TextBoxInputType = LollipopTextBox.InputType.None;
            this.lollipopTextBox2.TextBoxInputTypeMessage = "This field is string";
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.Caption = "Name";
            this.lollipopTextBox1.CaptionFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopTextBox1.CaptionForceColor = System.Drawing.Color.Gray;
            this.lollipopTextBox1.FocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.lollipopTextBox1.FontColor = System.Drawing.Color.Gray;
            this.lollipopTextBox1.HelpTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lollipopTextBox1.HelpTextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.LineColor = System.Drawing.Color.Silver;
            this.lollipopTextBox1.Location = new System.Drawing.Point(348, 98);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.MostComplete = true;
            this.lollipopTextBox1.MostCompleteMessage = "This field is required";
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.PasswordChar = false;
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(300, 40);
            this.lollipopTextBox1.TabIndex = 0;
            this.lollipopTextBox1.Text = "yes ";
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.TextBoxBackColor = System.Drawing.Color.White;
            this.lollipopTextBox1.TextBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopTextBox1.TextBoxInputType = LollipopTextBox.InputType.Numric;
            this.lollipopTextBox1.TextBoxInputTypeMessage = "This field is required";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 639);
            this.Controls.Add(this.lollipopFileInput1);
            this.Controls.Add(this.lollipopTextBox2);
            this.Controls.Add(this.lollipopTextBox1);
            this.Name = "Main";
            this.Text = "ComU";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopTextBox lollipopTextBox1;
        private LollipopTextBox lollipopTextBox2;
        private LollipopFileInput lollipopFileInput1;
    }
}

