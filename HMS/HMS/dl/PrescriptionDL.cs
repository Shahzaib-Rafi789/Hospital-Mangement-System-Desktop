using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
    class PrescriptionDL
    {
        static public List<Prescription> Prescriptions = new List<Prescription>();

        static public void AddPrescriptionIntoList(Prescription P)
        {
            Prescriptions.Add(P);
        }

        static public void LoadPrescriptions(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);

            if(File.Exists(path))
            {
                while((record = file.ReadLine()) != null)
                {
                    string Id;
                    string[] splitRecords = record.Split(',');
                    Id = splitRecords[0];

                    string[] medicine = splitRecords[1].Split(';');
                    string[] pattern = splitRecords[2].Split(';');
                    List<Medicine> medicines = new List<Medicine>();
                    List<string> patterns = new List<string>();
                    
                    for (int i = 0; i < medicine.Length; i++)
                    {
                        string[] furthurMedSplit = medicine[i].Split(':');
                        medicines.Add(new Medicine(furthurMedSplit[0], int.Parse(furthurMedSplit[1])));
                        patterns.Add(pattern[i]);
                    }                    

                    Prescription P = new Prescription(Id, medicines, patterns);
                    AddPrescriptionIntoList(P);
                }
            }
            file.Close();

        }

        static public Prescription GetPatientPrescription(string id)
        {
            foreach(Prescription i in Prescriptions)
            {
                if(i.PatientId == id)
                {
                    return i;
                }
            }
            return null;
        }

        static public void StorePrescriptionInFile(Prescription P)
        {
            string path = "Prescriptions.txt", record1, record2;
            StreamWriter file = new StreamWriter(path, true);

            record1 = P.Medicines[0].Name + ':' + P.Medicines[0].Quantity.ToString();
            record2 = P.Pattern[0];
            for (int i = 1; i < P.Medicines.Count; i++)
            {
                record1 += ';' + P.Medicines[i].Name + ':' + P.Medicines[i].Quantity.ToString();
                record2 += ';' + P.Pattern[i];
            }

            file.WriteLine(P.PatientId + ',' + record1 + ',' + record2);
            file.Flush();
            file.Close();
        }
    }
}
