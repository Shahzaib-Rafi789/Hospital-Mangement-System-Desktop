using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.bl;

namespace HMS.dl
{
    class EmployeeDL
    {
        static public List<Employee> Employees = new List<Employee>();

        static public void AddEmpIntoList(Employee Emp)
        {
            Employees.Add(Emp);
        }

        static public void LoadEmpData(string path)
        {
            string Record;
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                while ((Record = file.ReadLine()) != null)
                {
                    string[] SplittedRecords = Record.Split(',');
                    Employee emp = new Employee(SplittedRecords[0], SplittedRecords[1], SplittedRecords[2], SplittedRecords[3], SplittedRecords[4], double.Parse(SplittedRecords[5]), SplittedRecords[6], SplittedRecords[7]);
                    AddEmpIntoList(emp);
                }
            }

            file.Close();
        }

        static public Employee GetEmpObject(string Id)
        {
            foreach(Employee i in Employees)
            {
                if(i.Id == Id)
                {
                    return i;
                }
            }
            return null;
        }

        static public Employee SearchStaff(string Id, string Password)
        {
            foreach (Employee i in Employees)
            {
                if (i.Id == Id && i.Password == Password)
                {
                    if(i.Role == "Doctor")
                    {
                        return DoctorDL.GetDocObj(Id);
                    }
                    else if(i.Role == "Receptionist")
                    {
                        return ReceptionistDL.GetReceptObj(Id);
                    }
                    break;
                }
            }
            return null;
        }
    }
}
