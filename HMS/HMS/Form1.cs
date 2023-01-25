using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribution_Managment_System.BL;
using Distribution_Managment_System.DL;

namespace Distribution_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UserDL.AddUser(new Admin("Ab", "", "", "", "", ""));
            UserDL.AddUser(new Sale_Representative("b", "", "", "", "", "", "hh"));

            Sale_Representative a = (Sale_Representative)(UserDL.RetrieveUser("b"));
            label1.Text = a.region;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
