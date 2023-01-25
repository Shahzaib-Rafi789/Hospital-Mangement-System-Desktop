using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
    class ReceptionistDL
    {
        static public List<Receptionist> Receptionists = new List<Receptionist>();

        static public void AddReceptIntoList(Receptionist Recept)
        {
            Receptionists.Add(Recept);
        }

        static public void LoadReceptData(string path)
        {
            string Record;
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                while ((Record = file.ReadLine()) != null)
                {
                    string[] SplittedRecords = Record.Split(',');
                    Employee Emp = EmployeeDL.GetEmpObject(SplittedRecords[0]);
                    Receptionist Recept = new Receptionist(Emp);
                    AddReceptIntoList(Recept);
                }
            }

            file.Close();
        }

        static public Receptionist GetReceptObj(string Id)
        {
            foreach(HMS.bl.Receptionist i in Receptionists)
            {
                if (Id == i.Id)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
