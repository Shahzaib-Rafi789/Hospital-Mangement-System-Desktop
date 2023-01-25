using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
    class PatientDL
    {
        static public List<Patient> Patients = new List<Patient>();

        static public void AddPatientIntoList(Patient P)
        {
            Patients.Add(P);            
        }

        static public void LoadPatientData(string path)
        {
            string Record;
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                while ((Record = file.ReadLine()) != null)
                {
                    string[] SplittedRecords = Record.Split(',');
                    Room R = null;
                    Date A_Date = null, D_Date = null;
                    Prescription prescription = null;

                    if (SplittedRecords[6] != "") { R = RoomDL.GetRoomObj(SplittedRecords[6]); }
                    if(SplittedRecords[7] != "") { A_Date.AssignValue(SplittedRecords[7]); }
                    if(SplittedRecords[8] != "") { D_Date.AssignValue(SplittedRecords[8]); }
                    prescription = PrescriptionDL.GetPatientPrescription(SplittedRecords[1]);

                    Patient P = new Patient(SplittedRecords[0], SplittedRecords[1], SplittedRecords[2], double.Parse(SplittedRecords[3]), int.Parse(SplittedRecords[4]), SplittedRecords[5], R, A_Date, D_Date, prescription, DoctorDL.GetDocObj(SplittedRecords[10]));
                    AddPatientIntoList(P);
                }
            }

            file.Close();
        }

        static public void AddPatientIntoFile(Patient P)
        {
            string path = "Patients.txt";
            StreamWriter file = new StreamWriter(path,true);
            string Room = "",A_Date = "",D_Date = "",PrescriptId = "";
            if(P.Room != null) { Room = P.Room.Name; }
            if(P.AdmitDate != null) { A_Date = P.AdmitDate.ConvertToString(); }
            if(P.DischargeDate != null) { D_Date = P.DischargeDate.ConvertToString(); }

            file.WriteLine(P.Name + ',' + P.Id + ',' + P.Password + ',' + P.Bill + ',' + P.Age + ',' + P.Gender + ',' + Room + ',' + A_Date + ',' + D_Date + ',' + PrescriptId +',' +P.ConsultedDoctor.Id);
            file.Flush();
            file.Close();
        }

        static public void UpdateFile()
        {
            StreamWriter file = new StreamWriter("Patients.txt", false);
            foreach(Patient i in Patients)
            {
                string Room = "", A_Date = "", D_Date = "", PrescriptId = "";
                if (i.Room != null) { Room = i.Room.Name; }
                if (i.AdmitDate != null) { A_Date = i.AdmitDate.ConvertToString(); }
                if (i.DischargeDate != null) { D_Date = i.DischargeDate.ConvertToString(); }

                file.WriteLine(i.Name + ',' + i.Id + ',' + i.Password + ',' + i.Bill + ',' + i.Age + ',' + i.Gender + ',' + Room + ',' + A_Date + ',' + D_Date + ',' + PrescriptId + ',' + i.ConsultedDoctor.Id);
                file.Flush();
            }

            file.Close();
        }

        static public Patient GetPatObj(string id)
        {
            foreach (Patient i in Patients)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }

        static public Patient SearchPatient(string id, string password)
        {
            foreach(Patient i in Patients)
            {
                if(i.Id == id && i.Password == password)
                {
                    return i;
                }
            }
            return null;
        }

        static public void RemovePatient(Patient P)
        {
            Patients.Remove(P);
        }

        static public void UpdatePatientData(string id, Patient updated)
        {
            foreach(Patient i in Patients)
            {
                if(i.Id == id)
                {
                    i.Name = updated.Name;
                    i.Bill = updated.Bill;
                    i.Age = updated.Age;
                    i.Gender = updated.Gender;
                    if (i.Room != updated.Room)
                    {
                        if (i.Room != null)
                        {
                            RoomDL.GetRoomObj(i.Room.Name).ChangeStatus();
                            RoomDL.UpdateRoomInFile("Rooms.txt");
                            i.DeAllocateRoom();
                        }

                        if(updated.Room != null)
                        {
                            RoomDL.GetRoomObj(updated.Room.Name).ChangeStatus();
                            RoomDL.UpdateRoomInFile("Rooms.txt");
                            i.AllocateRoom(updated.Room);
                        }
                    }
                    break;
                }
            }
        }

        static public string GetNextId()
        {
            int n = Patients.Count + 1;
            return ("P" + n.ToString());
        }
    }
}
