using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
        class AppointmentDL
        {
            static public List<Appointment> Appointments = new List<Appointment>();

            static public void AddAppointmentIntoList(Appointment A)
            {
                Appointments.Add(A);
            }

            static public void LoadAppointmentsData(string path)
            {
                string record;
                StreamReader file = new StreamReader(path);

                while((record = file.ReadLine()) != null)
                {
                    string[] splitRecords = record.Split(',');
                    Date date = null;
                    date.AssignValue(splitRecords[2]);
                    Appointment A = new Appointment(splitRecords[0], splitRecords[1], date, splitRecords[3]);
                    AddAppointmentIntoList(A);
                }

                file.Close();
            }

            static public void AddAppointmentIntoFile(Appointment A)
            {
                StreamWriter file = new StreamWriter("Appointments.txt", true);
                file.WriteLine(A.PatId + ',' + A.DocId + ',' + A.AppointmentTime.ConvertToString() + A.Status);
                file.Flush();
                file.Close();
            }
        }
}
