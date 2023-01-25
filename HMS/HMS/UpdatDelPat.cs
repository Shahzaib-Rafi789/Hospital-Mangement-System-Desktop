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
    public partial class UpdatDelPat : Form
    {
        public string id;
        public Patient P;
        public UpdatDelPat()
        {
            InitializeComponent();
            subPanel.Visible = false;
        }

        private void UpdatDelPat_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            id = txtbxPatId.Text;
            if(id != "")
            {
                P = PatientDL.GetPatObj(id);
                if (P != null)
                {
                    subPanel.Visible = true;
                    PlaceDataInTxtBoxes(P);
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Patient ID!","Error");
            }
        }

        private void PlaceDataInTxtBoxes(Patient P)
        {
            txtbxName.Text = P.Name;
            txtbxAge.Text = P.Age.ToString();
            cmbbxGender.SelectedItem = P.Gender;
            txtbxBill.Text = P.Bill.ToString();
            txtbxRoom .Text= "";
            if (P.Room != null)
            {
                txtbxRoom.Text = P.Room.Name;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            id = txtbxPatId.Text;
            if (id != "")
            {
                if ((P = PatientDL.GetPatObj(id)) != null)
                {
                    PatientDL.RemovePatient(P);
                    PatientDL.UpdateFile();
                    P.Room.ChangeStatus();
                    RoomDL.UpdateRoomInFile("Rooms.txt");
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Patient ID!", "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Room R = null ;
            bool flag = false;

            if(txtbxName.Text != "" && txtbxAge.Text != "" && txtbxBill.Text != "" && cmbbxGender.SelectedItem != null)
            {                
                if (txtbxRoom.Text == "")
                {
                    flag = true;                    
                }

                else if((R = RoomDL.GetRoomObj(txtbxRoom.Text)) != null)
                {
                    if(R.IsRoomFree())
                    {
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("Room Occupied!","Error");
                    }
                }

                else
                {
                    MessageBox.Show("No Such Room Exists!", "Error");
                }
            }

            else
            {
                MessageBox.Show("Enter Complete Data!","Error");
            }

            if(flag)
            {
                Patient P1 = new Patient(txtbxName.Text, P.Id, P.Password, double.Parse(txtbxBill.Text),int.Parse(txtbxAge.Text), cmbbxGender.SelectedItem.ToString(), R, P.ConsultedDoctor);
                PatientDL.UpdatePatientData(id, P1);
                PatientDL.UpdateFile();

                MessageBox.Show("Updated", "Status");
                subPanel.Visible = false;
                this.Hide();
            }
        }

        private void txtbxBill_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(txtbxBill.Text);
            }
            catch
            {
                if (txtbxBill.Text != "")
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
                if (txtbxAge.Text != "")
                {
                    txtbxAge.Text = txtbxAge.Text.Remove(txtbxAge.Text.Length - 1);
                }
            }
        }
    }
}
