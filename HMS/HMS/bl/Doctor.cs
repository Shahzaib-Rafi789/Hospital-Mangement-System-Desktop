using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Doctor : Employee
    {
        private string qualification;
        private string speciality;

        public Doctor(Employee Emp, string qualification, string speciality) : base(Emp)
        {
            Qualification = qualification;
            Speciality = speciality;
        }

        public Doctor(string name, string id, string password, string role, string shifts, double salary, string gender, string contact, string qualification, string speciality,List<Patient> patients): base(name, id, password, role, shifts, salary, gender, contact)
        {
            Qualification = qualification;
            Speciality = speciality;
        }

        public string Qualification { get => qualification; set => qualification = value; }
        public string Speciality { get => speciality; set => speciality = value; }     
    }
}
