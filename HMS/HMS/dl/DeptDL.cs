using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;
using HMS.dl;

namespace HMS.dl
{
        class DeptDL
        {
            static public List<Dept> Depts = new List<Dept>();

            static public void AddDeptIntoList(Dept dept)
            {
                Depts.Add(dept);
            }

            static public void LoadDeptData(string path)
            {
                string Record;
                StreamReader file = new StreamReader(path);

                if (File.Exists(path))
                {
                    while ((Record = file.ReadLine()) != null)
                    {
                        string[] SplittedRecords = Record.Split(',');
                        string[] FurthurSplitted = SplittedRecords[2].Split(';');
                        List<Doctor> D = new List<Doctor>();

                        for(int i=0; i<D.Count; i++)
                        {
                            D.Add(DoctorDL.GetDocObj(FurthurSplitted[i]));
                        }
                        Dept dept = new Dept(int.Parse(SplittedRecords[0]), SplittedRecords[1], D);
                        AddDeptIntoList(dept);
                    }
                }

                file.Close();
            }
        }
}
