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
    public partial class PatientForm : Form
    {
        private Patient patient;
        private Form activeForm = null;
        public PatientForm(Patient P)
        {
            InitializeComponent();
            patient = P;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

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

        private void btnPrescript_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckPrescriptions(patient));
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MakeAppointment(patient));
        }

        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }
    }
}
