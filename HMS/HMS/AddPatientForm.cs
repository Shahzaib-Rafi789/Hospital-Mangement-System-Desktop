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
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
            string n;
            cmbbxdoc.Items.Clear();
            foreach(Doctor Doc in DoctorDL.Doctors)
            {
                n = Doc.Id + ',' + Doc.Name;
                cmbbxdoc.Items.Add(n);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Room R = null;
            bool flag = false;

            if (txtbxName.Text != "" && txtbxAge.Text != "" && txtbxBill.Text != "" && cmbbxGender.SelectedItem != null && cmbbxdoc.SelectedItem != null)
            {
                if (txtbxRoom.Text == "")
                {
                    flag = true;
                }

                else if ((R = RoomDL.GetRoomObj(txtbxRoom.Text)) != null)
                {
                    if (R.IsRoomFree())
                    {
                        flag = true;
                        R.ChangeStatus();
                        RoomDL.UpdateRoomInFile("Rooms.txt");
                    }
                    else
                    {
                        MessageBox.Show("Room Occupied!", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("No Such Room Exists!", "Error");
                }
            }

            else
            {
                MessageBox.Show("Enter Complete Data!", "Error");
            }

            if (flag)
            {
                string NextId = PatientDL.GetNextId(), NextPsword = NextId;
                string[] n = cmbbxdoc.SelectedItem.ToString().Split(',');
                Patient P1 = new Patient(txtbxName.Text, NextId, NextPsword, double.Parse(txtbxBill.Text), int.Parse(txtbxAge.Text), cmbbxGender.SelectedItem.ToString(), R, DoctorDL.GetDocObj(n[0]));
                PatientDL.AddPatientIntoList(P1);
                PatientDL.AddPatientIntoFile(P1);

                MessageBox.Show("Patient Added", "Message");
                this.Hide();
            }
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbxBill_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(txtbxBill.Text);
            }
            catch
            {
                if(txtbxBill.Text != "")
                {
                    txtbxBill.Text = txtbxBill.Text.Remove(txtbxBill.Text.Length - 1);
                }
            }
        }

        private void txtbxAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtbxAge.Text);
            }
            catch
            {
                if(txtbxAge.Text != "" || txtbxAge.Text.ElementAt(txtbxAge.Text.Length - 1) =='.')
                {
                    txtbxAge.Text = txtbxAge.Text.Remove(txtbxAge.Text.Length - 1);
                }
            }
        }

        private void cmbbxdoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblConsultDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
