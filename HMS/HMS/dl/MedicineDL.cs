using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
    class MedicineDL
    {
        static public List<Medicine> Medicines = new List<Medicine>();

        static public void AddMedIntoList(Medicine Med)
        {
            Medicines.Add(Med);
        }

        static public void LoadMedData(string path)
        {
            string Record;
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                while ((Record = file.ReadLine()) != null)
                {
                    string[] SplittedRecords = Record.Split(',');
                    Medicine Med = new Medicine(SplittedRecords[0], SplittedRecords[1], double.Parse(SplittedRecords[2]), int.Parse(SplittedRecords[3]), int.Parse(SplittedRecords[4]));
                    AddMedIntoList(Med);
                }
            }

            file.Close();
        }

        static public Medicine GetMedObj(string name)
        {
            foreach(Medicine i in Medicines)
            {
                if(i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
