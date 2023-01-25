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
    public partial class ShowPatients : Form
    {
        public ShowPatients()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            DataTable t = new DataTable();
            string roomName = "";

            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Age", typeof(int));
            t.Columns.Add("Gender", typeof(string));
            t.Columns.Add("Bill", typeof(double));
            t.Columns.Add("Room", typeof(string));
            t.Columns.Add("Consulted Doctor", typeof(string));
            foreach (Patient i in PatientDL.Patients)
            {
                if(i.Room != null) { roomName = i.Room.Name; }
                t.Rows.Add(i.Name, i.Age, i.Gender, i.Bill, roomName, i.ConsultedDoctor.Name);
            }
            dataGridView1.DataSource = t;
            dataGridView1.ReadOnly = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
