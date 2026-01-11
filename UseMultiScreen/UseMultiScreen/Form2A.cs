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
    public partial class Form2A : Form
    {
        public Form2A(string text)
        {
            InitializeComponent();
            this.lblOutput.Text = text;
        }
        public Form2A()
        {
            InitializeComponent();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void blprevious_Click(object sender, EventArgs e)
        {
            
        }
    }
}
