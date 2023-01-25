using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    class Receptionist : Employee
    {
        public Receptionist(Employee Emp): base(Emp)
        {

        }

        public Receptionist(string name, string id, string password, string role, string shifts, double salary, string gender, string contact): base(name, id, password, role, shifts, salary, gender, contact)
        {

        }
    }
}
