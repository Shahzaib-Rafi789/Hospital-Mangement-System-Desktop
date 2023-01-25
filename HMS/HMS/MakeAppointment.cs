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
    public partial class MakeAppointment : Form
    {
        private Patient patient;
        public MakeAppointment(Patient P)
        {
            InitializeComponent();
            patient = P;
            string n;
            cmbbxdoc.Items.Clear();
            foreach (Doctor Doc in DoctorDL.Doctors)
            {
                n = Doc.Id + ',' + Doc.Name;
                cmbbxdoc.Items.Add(n);
            }
        }

        private void cmbbxdoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private bool IsDateCorrect()
        {
            Date date = new Date(DateTime.Today.ToString("d"));
            if(date.Year >= int.Parse(txtbxYear.Text))
            {
                if(date.Month >= int.Parse(txtbxMonth.Text))
                {
                    if(date.Month > int.Parse(txtbxMonth.Text) || (date.Month == int.Parse(txtbxMonth.Text) && date.Day >= int.Parse(txtbxDaay.Text)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cmbbxdoc.SelectedItem != null && txtbxDaay.Text != "" && txtbxMonth.Text != "" && txtbxYear.Text != "")
            {
                if(IsDateCorrect())
                {
                    string[] DocData = cmbbxdoc.SelectedItem.ToString().Split(',');
                    Appointment A = new Appointment(patient.Id, DocData[0], new Date(int.Parse(txtbxDaay.Text), int.Parse(txtbxMonth.Text), int.Parse(txtbxYear.Text)), "InProcess");
                    AppointmentDL.AddAppointmentIntoList(A);
                    AppointmentDL.AddAppointmentIntoList(A);

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You cannot select previous days");
                }
            }
            else
            {
                MessageBox.Show("Enter Complete Data");
            }
        }
    }
}
