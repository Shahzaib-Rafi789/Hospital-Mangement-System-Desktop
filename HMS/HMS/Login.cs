using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.dl;
using HMS.bl;

namespace HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Patient P;
            Employee Emp = EmployeeDL.SearchStaff(txtUserame.Text, txtPassword.Text);
            if (Emp != null)
            {
                if (Emp.Role == "Doctor")
                {
                    DoctorForm NewForm = new DoctorForm(DoctorDL.GetDocObj(txtUserame.Text));
                    this.Hide();
                    NewForm.Show();
                }
                else if (Emp.Role == "Receptionist") 
                {
                    ReceptionistForm NewForm = new ReceptionistForm();
                    this.Hide();
                    NewForm.Show();
                }

            }

            else if((P = PatientDL.SearchPatient(txtUserame.Text, txtPassword.Text)) != null)
            {
                PatientForm NewForm = new PatientForm(P);
                this.Hide();
                NewForm.Show();
            }

            else
            {
                MessageBox.Show("Not Found","Error");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }
    }
}
