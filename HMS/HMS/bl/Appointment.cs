using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS. dl;

namespace HMS.bl
{
    public class Appointment
    {
        string patId;
        string docId;
        Date appointmentTime;
        string status;

        public Appointment(string patId, string docId, Date appointmentTime, string status)
        {
            this.PatId = patId;
            this.DocId = docId;
            this.AppointmentTime = appointmentTime;
            this.Status = status;
        }

        public string PatId { get => patId; set => patId = value; }
        public string DocId { get => docId; set => docId = value; }
        public Date AppointmentTime { get => appointmentTime; set => appointmentTime = value; }
        public string Status { get => status; set => status = value; }
    }
}
