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
    public partial class ViewDocPatients : Form
    {
        private Doctor Doc;
        public ViewDocPatients(Doctor D)
        {
            InitializeComponent();
            Doc = D;
            LoadGrid();
        }

        private void LoadGrid()
        {
            DataTable t = new DataTable();
            string roomName = "";

            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Age", typeof(int));
            t.Columns.Add("Gender", typeof(string));
            t.Columns.Add("Room", typeof(string));
            
            foreach (Patient i in PatientDL.Patients)
            {
                if (Doc.Id == i.ConsultedDoctor.Id)
                {
                    if (i.Room != null) { roomName = i.Room.Name; }
                    t.Rows.Add(i.Name, i.Age, i.Gender, roomName);
                }
            }
            DGWpatient.DataSource = t;
            DGWpatient.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
