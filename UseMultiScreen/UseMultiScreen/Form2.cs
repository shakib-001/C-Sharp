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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //
            //bbbbbbbbbbb

            this.Visible=false;
            Form2A fb = new Form2A(this.textinput.Text);
            fb.Show();
        }
    }
}
