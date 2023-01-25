using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Employee
    {
        protected string name;
        protected string id;
        protected string password;
        protected string role;
        private string shifts;
        protected double salary;
        protected string gender;
        protected string contact;

        public Employee(string name, string id, string password, string role, string shifts, double salary, string gender, string contact)
        {
            this.Name = name;
            this.Id = id;
            this.Password = password;
            this.Role = role;
            this.Shifts = shifts;
            this.Salary = salary;
            this.Gender = gender;
            this.Contact = contact;
        }

        public Employee(Employee Emp)
        {
            this.Name = Emp.Name;
            this.Id = Emp.id;
            this.Password = Emp.password;
            this.Role = Emp.role;
            this.Shifts = Emp.shifts;
            this.Salary = Emp.salary;
            this.Gender = Emp.gender;
            this.Contact = Emp.contact;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Shifts { get => shifts; set => shifts = value; }
    }
}
