using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klik.Windows.Forms.v1.EntryLib;
using System.Windows.Forms;

namespace Commu
{
    public partial class Main : Form
    {
        ELModalBox ModalBoxx;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tphoto.Filter = "All Images | *.BMP; *.JPG; *.JPEG; *.JPE;*.PNG";
            ModalBoxx = new ELModalBox();
            ModalBoxx.Show(this, panel1);
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {

            // in vase ine ke agar natije start va etesal be client ture shod modalbox baste beshe age false shod payam neshon dade beshe !!!
            // request hamoon natije etesal hast
            bool request = true;

            if (tname.Text != "" && tip.Text != "" && tport.Text != "")
            { 
                if (request)
                {
                    // in hamoon modal baxi hast ke aval ijad  mishe ta ghesmate connection biad ta yaroo address,ip, va port ro kame kone 
                    // choon natije true mishe pass bayad ghat beshe va karbar shoro be chat kardan bookone 
                    ModalBoxx.Close();
                    tmessage.Caption = "Write your message ... !";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    tmessage.IsEnabled = true;
                    connectbtn.Text = "Disconnect";
                    connectbtn.BackColor = Color.DarkRed;
                    try
                    {
                        lollipopSmallCard1.Text = tname.Text;
                        lollipopSmallCard1.Info = "Server";
                        lollipopSmallCard1.Image = Image.FromFile(tphoto.Text);
                    }
                    catch
                    {

                    }

                }
                else
                {
                    // agar connection ghat bood ye error bede 
                    ELModalBox elmodal = new ELModalBox();
                    LollipopLabel message = new LollipopLabel();
                    message.Visible = true;
                    message.TextAlign = ContentAlignment.MiddleCenter;
                    message.BackColor = Color.LightSeaGreen;
                    message.ForeColor = Color.White;
                    message.Width = 230;
                    message.Cursor = Cursors.Hand;
                    // matn error 
                    message.Text = "Error in connection";
                    elmodal.Show(panel1, message);
                }
            }
        }

        private void lollipopTextBox4_EnterPress(object sender, EventArgs e)
        {
            // ye event to lollipopbutton be esme EnterPress tarif karadm ke vaghti enter bezane in function ejra beshe 
            // agar enter zade beshe payam frestade mishe
            listBox1.Items.Add(lollipopSmallCard1.Text + " ---> " + tmessage.Text);
            tmessage.Text = "";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // har vaght mouse bere ro mic iconesh taghyir peyda mikone 
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            // har vaght mouse bere ro attachment ya (gire) iconesh taghyir peyda mikone 
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // vaghti ro gire click mishe in etefaghat biyofte 
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "All File | *.*";

        }

        private void lollipopButton2_Click(object sender, EventArgs e)
        {
            ModalBoxx = new ELModalBox();
            ModalBoxx.Show(this, panel1);
        }
    }
}
