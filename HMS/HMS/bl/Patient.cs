using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Patient
    {
        private string name;
        private string id;
        private string password;
        private double bill;
        private int age;
        private string gender;
        private Room room;
        private Date admitDate;
        private Date dischargeDate;
        private Prescription prescription;
        private Doctor consultedDoctor;

        public Patient(string name, string id, string password,int age, string gender, Doctor consultedDoctor)
        {
            this.Name = name;
            this.Id = id;
            this.Password = password;
            this.Age = age;
            this.Gender = gender;
            Bill = 0;
            Room = null;
            AdmitDate = null;
            DischargeDate = null;
            this.Prescription = null;
            ConsultedDoctor = consultedDoctor;
        }

        public Patient(string name, string id, string password, double bill, int age, string gender, Room room, Doctor consultedDoctor)
        {
            this.Name = name;
            this.Id = id;
            this.Password = password;
            this.Bill = bill;
            this.Age = age;
            this.Gender = gender;
            this.Room = room;
            this.AdmitDate = null;
            this.DischargeDate = null;
            this.Prescription = null;
            ConsultedDoctor = consultedDoctor;
        }

        public Patient(string name, string id, string password, double bill, int age, string gender, Room room, Date admitDate, Date dischargeDate, Prescription prescription, Doctor consultedDoctor)
        {
            this.Name = name;
            this.Id = id;
            this.Bill = bill;
            this.Password = password;
            this.Age = age;
            this.Gender = gender;
            this.Room = room;
            this.AdmitDate = admitDate;
            this.DischargeDate = dischargeDate;
            this.Prescription = prescription;
            ConsultedDoctor = consultedDoctor;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public double Bill { get => bill; set => bill = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public Room Room { get => room; set => room = value; }
        public Date AdmitDate { get => admitDate; set => admitDate = value; }
        public Date DischargeDate { get => dischargeDate; set => dischargeDate = value; }
        public string Password { get => password; set => password = value; }
        public Prescription Prescription { get => prescription; set => prescription = value; }
        internal Doctor ConsultedDoctor { get => consultedDoctor; set => consultedDoctor = value; }

        public void DeAllocateRoom()
        {
            if(Room != null)
            {
                Room = null;
            }
        }

        public void AllocateRoom(Room R)
        {
            Room = R;
        }
    }
}
