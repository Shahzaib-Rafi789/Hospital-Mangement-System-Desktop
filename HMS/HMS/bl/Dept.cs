using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    class Dept
    {
        private int id;
        private string name;
        List<Doctor> doctors;

        public Dept(int id, string name, List<Doctor> doctors)
        {
            this.Id = id;
            this.Name = name;
            this.Doctors = doctors;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal List<Doctor> Doctors { get => doctors; set => doctors = value; }
    }
}
