using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.bl;
using HMS.dl;

namespace HMS
{
    public partial class DoctorForm : Form
    {
        private Form activeForm = null;
        private Doctor Doc;

        public DoctorForm(Doctor D)
        {
            InitializeComponent();
            Doc = D;
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            //ChildForm.FormBorderStyle = FormBorderStyle.None;
            //ChildForm.Dock = DockStyle.None;            

            childPanel.Controls.Add(ChildForm);
            childPanel.Tag = ChildForm;
            //childPanel.Dock = DockStyle.None;
            childPanel.Anchor = AnchorStyles.None;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void btPatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDocPatients(Doc));
        }

        private void btnPrescript_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GivePrescription());
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }

        private void childPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
