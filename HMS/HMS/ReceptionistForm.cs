using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class ReceptionistForm : Form
    {
        private Form activeForm = null;
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form ChildForm)
        {
            if(activeForm != null) { activeForm.Close(); }
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

        private void btnPatient_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            HidePatientSubMenu();
        }

        private void HidePatientSubMenu()
        {
            if(subPanelPatient.Visible == true)
            {
                subPanelPatient.Visible = false;
            }
        }

        private void ShowPatientSubMenu()
        {
            if (subPanelPatient.Visible == false)
            {
                HidePatientSubMenu();
                subPanelPatient.Visible = true;
            }
            else
            {
                subPanelPatient.Visible = false;
            }
        }

        private void btPatient_Click(object sender, EventArgs e)
        {
            ShowPatientSubMenu();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            HidePatientSubMenu();
            OpenChildForm(new DocTimeTable());
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            HidePatientSubMenu();
        }

        private void btnAddPat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPatientForm());
        }

        private void btnUpdatDel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdatDelPat());
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowPatients());
        }

        private void ReceptionistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }
    }
}
