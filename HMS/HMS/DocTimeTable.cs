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
    public partial class DocTimeTable : Form
    {
        public DocTimeTable()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            DataTable t = new DataTable();
            t.Columns.Add("Doctor ID", typeof(string));
            t.Columns.Add("Doctor Name", typeof(string));
            t.Columns.Add("Shift", typeof(string));

            foreach(Doctor i in DoctorDL.Doctors)
            {
                t.Rows.Add(i.Id, i.Name, i.Shifts);
            }

            DGWtimetable.DataSource = t;
        }

        private Color GetShiftColor(Doctor Doc)
        {
            if(Doc.Shifts == "Morning") { return Color.Red; }
            else if(Doc.Shifts == "Evening") { return Color.Green; }
            return Color.Blue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGWtimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
