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
    public partial class UpdateDelPatient : Form
    {
        public string id;
        public UpdateDelPatient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Patient obj;
            if (txtbxPatId.Text != "" && ((obj = PatientDL.GetPatObj(txtbxPatId.Text)) != null))
            {
                id = obj.Id;
                panel2.Visible = true;
                txtbxNae.Text = obj.Name;
                txtbexAge.Text = obj.Age.ToString();
                cmbbxGeder.SelectedItem = obj.Gender;
                txtbxBill.Text = obj.Bill.ToString();
                if(obj.Room != null) { txtbxRoom.Text = obj.Room.Name; }
            }
            else
            {
                MessageBox.Show("Invalid Id","Error");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Patient obj;
            if (txtbxPatId.Text != "" && ((obj = PatientDL.GetPatObj(txtbxPatId.Text)) != null))
            {
                PatientDL.RemovePatient(obj);
            }
            else
            {
                MessageBox.Show("Invalid Id", "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Room R;
            bool flag = true;
            if (txtbexAge.Text != "" && txtbxBill.Text!="" && txtbxNae.Text!="")
            {
                R = null;
                if(txtbxRoom.Text != "")
                {
                    if((R=RoomDL.GetRoomObj(txtbxRoom.Text)) == null)
                    
                    {
                        MessageBox.Show("Incorrect Data", "Error");
                        flag = false;
                    }
                }

                if(flag == true)
                {
                    Patient Updated = new Patient(txtbxNae.Text,id,id,double.Parse(txtbxBill.Text),int.Parse(txtbexAge.Text),cmbbxGeder.SelectedItem.ToString(),R);
                    PatientDL.UpdatePatientData(id, Updated);
                }

            }
            else
            {
                MessageBox.Show("Incomplete Input", "Error");
            }
        }
    }
}
