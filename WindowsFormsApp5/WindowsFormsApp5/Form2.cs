using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        string studentID;
        string fullName;
        string department;
        public Form2(string id, string name)
        {
            studentID = id;
            fullName = name;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            department = cmbDepartment.SelectedItem.ToString();
            
            Form3 f3 = new Form3(studentID, fullName, department);
            this.Hide();
            f3.Show();
        }
    }
}
