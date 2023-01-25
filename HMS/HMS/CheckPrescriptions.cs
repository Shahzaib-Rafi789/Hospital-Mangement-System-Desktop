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
    public partial class CheckPrescriptions : Form
    {
        public Patient patient;
        public CheckPrescriptions(Patient P)
        {
            InitializeComponent();
            patient = P;
        }

        private void CheckPrescriptions_Load(object sender, EventArgs e)
        {
            if (patient.Prescription != null)
            {
                DataTable t = new DataTable();
                t.Columns.Add("Medicine", typeof(string));
                t.Columns.Add("Quantity", typeof(int));
                t.Columns.Add("Pattern", typeof(string));
                for(int i=0; i<patient.Prescription.Medicines.Count; i++)
                {
                    t.Rows.Add(patient.Prescription.Medicines[i].Name, patient.Prescription.Medicines[i].Quantity, patient.Prescription.Pattern[i]);
                }

                dataGridView1.DataSource = t;
                dataGridView1.ReadOnly = true;
            }
            else
            {
                lblResult.Text = "No Prescription!";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
