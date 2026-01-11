using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseMultiScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.PnlOtuput.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PnlOtuput.Visible=false;
        }
    }
}
