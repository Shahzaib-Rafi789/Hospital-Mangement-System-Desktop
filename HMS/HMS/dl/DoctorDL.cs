using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
    class DoctorDL
    {
        static public List<Doctor> Doctors = new List<Doctor>();

        static public void AddDocIntoList(Doctor Doc)
        {
            Doctors.Add(Doc);
        }

        static public void LoadDocData(string path)
        {
            string Record;
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                while ((Record = file.ReadLine()) != null)
                {
                    string[] SplittedRecords = Record.Split(',');
                    Employee Emp = EmployeeDL.GetEmpObject(SplittedRecords[0]);
                    Doctor Doc = new Doctor(Emp, SplittedRecords[1], SplittedRecords[2]);
                    AddDocIntoList(Doc);
                }
            }

            file.Close();
        }

        static public Doctor GetDocObj(string id)
        {
            foreach(Doctor i in Doctors)
            {
                if(id == i.Id)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
