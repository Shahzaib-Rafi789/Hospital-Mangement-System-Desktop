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

namespace HMS
{
    public partial class ShowPatData : Form
    {
        public ShowPatData()
        {
            InitializeComponent();
            dataGridView1.DataSource = PatientDL.Patients.Select(c => new { Name = c.Name, c.Age,c.Gender,c.Bill,RoomName = c.Room.Name,Date = c.AdmitDate.toString(),Date1 = c.DischargeDate.toString()}).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
