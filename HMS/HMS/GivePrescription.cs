using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.dl;
using HMS.bl;
using System.Windows.Forms;

namespace HMS
{
    public partial class GivePrescription : Form
    {
        Patient P;
        public GivePrescription()
        {
            InitializeComponent();
            panel2.Visible = false;
            foreach (Medicine M in MedicineDL.Medicines)
            {
                cmbbxMedName.Items.Add(M.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbbxPattern.SelectedItem != null && txtbxQuatity.Text != "" && cmbbxMedName.SelectedItem != null)
            {
                if(!IsMedAlreadyAdded(cmbbxMedName.SelectedItem.ToString()))
                {
                    dataGridView1.Rows.Add(cmbbxMedName.SelectedItem.ToString(), txtbxQuatity.Text, cmbbxPattern.SelectedItem.ToString());                    
                }
                else
                {
                    MessageBox.Show("Medicine Already Added!", "Alert!");
                }
            }
            else
            {
                MessageBox.Show("Enter Complete Data!", "Alert!");
            }
        }

        private bool IsMedAlreadyAdded(string name)
        {
            for(int i=0; i<dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1.Rows[i].Cells[0].Value.ToString() == name)
                {
                    return true;
                }
            }

            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGivePrescript_Click(object sender, EventArgs e)
        {
            if(btnGivePrescript.Text != "")
            {
                if ((P = PatientDL.GetPatObj(txtbxPatId.Text)) != null)
                {
                    panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Enter Valid Id!", "Error");
                }
            }
            else
            {
                MessageBox.Show("TextBox Empty!", "Error");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                List<Medicine> meds = new List<Medicine>();
                List<string> patterns = new List<string>();
                
                for(int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    meds.Add(new Medicine(dataGridView1.Rows[i].Cells[0].Value.ToString(), int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString())));
                    patterns.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }

                Prescription prescription = new Prescription(P.Id, meds, patterns);
                P.Prescription = prescription;
                PrescriptionDL.AddPrescriptionIntoList(prescription);
                PrescriptionDL.StorePrescriptionInFile(prescription);
            }
            else
            {
                P.Prescription = null;
            }

            MessageBox.Show("Prescription Added!");
            panel2.Visible = false;
            this.Hide();
        }

        private void txtbxQuatity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtbxQuatity.Text);
            }
            catch
            {
                if (txtbxQuatity.Text != "" || txtbxQuatity.Text.ElementAt(txtbxQuatity.Text.Length - 1) == '.')
                {
                    txtbxQuatity.Text = txtbxQuatity.Text.Remove(txtbxQuatity.Text.Length - 1);
                }
            }
        }
    }
}
