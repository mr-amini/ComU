using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LollipopMessage a = new LollipopMessage();
                a.Text = "Left Message";
            lollipopXListBox1.Add(a,Components.Controls.LollipopXListBox.MessageAlignment.Left);

            LollipopMessage b = new LollipopMessage();
            b.Text = "Right Message";
            lollipopXListBox1.Add(b, Components.Controls.LollipopXListBox.MessageAlignment.Right);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
